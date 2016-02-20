#include "DNABandPositionExtraction.h"
#include "ColumnObject.h"
#include "GelUtils.h"
#include "BPValueGeneration.h"
#include "SegmentedImagePart.h"
#include "ImageSegmentation.h"
#include "opencv\cv.h"
#include "opencv\highgui.h"
#include <numeric>
#include <functional>
#include <fstream>
#include <vector>
#include <algorithm>
#include <iterator>
#include <iostream>

using namespace cv;
using namespace std;

DNABandPositionExtraction::DNABandPositionExtraction(void)
{
	this->maxIntensityCount = 0;	
	this->secondTopBandIndex = 0;
	this->lastBPPositionInLadder = 0;
	this->ladderDetected = false;
	this->secondTopBandDetected = false;
	this->isNoDNAColumnChecked = false;
	this->isSampleColumn = false;	
	this->isPositiveControllerValid=false;
	this->trueDMD=false;
	this->trueHD=false;
	this->trueStroke=false;
	this->trueNegativeController=false;
	this->isLadder50BP=true;

	//Threshold Values
	this->intensityThreshold = 0;
	this->approximatedBandDistanceThreshold = 50;
	this->numberOfAboveBands = 6;
	this->ratioOfLength = 0.6;
	this->columnValidityRatio = 0.7;
	this->columnValidityThreshold = 9;
	this->stokeBandLenthRatio = 0.75;
}

DNABandPositionExtraction::~DNABandPositionExtraction(void)
{
}

vector<ColumnObject> DNABandPositionExtraction::getFinallyExtractedImageColumnData(vector<SegmentedImagePart> segmentedImageParts){

	ofstream myfile;	
	myfile.open ("F:\\Images\\4yr project\\ProcessedImageData\\GEL_Image_Data_Positions.txt");
	
	vector<ColumnObject> columnDetails;
	ColumnObject *co=new ColumnObject();
	GelUtils *gUtils=new GelUtils();
	vector<SegmentedImagePart> neededSegmentedImageParts;
	vector<ColumnObject> columnsToBeCalculateBPValues;
	SegmentedImagePart positiveController;
	vector<SegmentedImagePart> negativeControllers;
	vector<SegmentedImagePart> noDNAImageParts;

	BPValueGeneration *bpValueGeneration=new BPValueGeneration();

	//accesing the segemented image parts
	for(int i = 0;i <segmentedImageParts.size(); i++){		

		if(!this->ladderDetected && segmentedImageParts[i].getDeseaseType() == "50 BP LADDER"||
			!this->ladderDetected && segmentedImageParts[i].getDeseaseType() == "100 BP LADDER"){

			this->maxIntensityCount = 0;
			//ColumnObject *co=new ColumnObject();
			this->ladderDetected=true;

			//get sum of row intensities
			vector<long> rowPixelIntensityValues = this->getIntensitiesAboveThreshold(segmentedImageParts[i].getImagePart(),this->intensityThreshold,0);

			//get ladder band positions with maximum points
			this->getLadderBandPositions(segmentedImageParts[i].getDeseaseType(),segmentedImageParts[i].getImagePart(),
				segmentedImageParts[i].getDeseaseType()+"_Graph_Image",rowPixelIntensityValues,this->maxIntensityCount,myfile);
		}

		//determine NO DNA column, it is necessary to have this
		if(segmentedImageParts[i].getDeseaseType() == "NO DNA")
			noDNAImageParts.push_back(segmentedImageParts[i]);		

		//determine positive controller column
		if(segmentedImageParts[i].getDeseaseType() == "(+) CONTROLLER")
			positiveController=segmentedImageParts[i];

		//determine patient samples column
		if(segmentedImageParts[i].getDeseaseType() != "NO DNA" && segmentedImageParts[i].getDeseaseType() != "NO BAND" 
			&& segmentedImageParts[i].getDeseaseType() !="100 BP LADDER" && segmentedImageParts[i].getDeseaseType() !="50 BP LADDER" 
			 && segmentedImageParts[i].getDeseaseType() != "(+) CONTROLLER")
			neededSegmentedImageParts.push_back(segmentedImageParts[i]);	

	}

	//checking no DNA column is valid
	if(this->ladderDetected){
		bool isNoDNAValid = false;

		//process NO DNA column/columns
		for(int x=0 ; x < noDNAImageParts.size() ; x++){
			this->maxIntensityCount = 0;

			vector<long> rowPixelIntensityValues = this->getIntensitiesAboveThreshold(noDNAImageParts[x].getImagePart(),
				this->intensityThreshold,0);

			vector<float> noDNABandPositions = this->getSampleBandPositions(noDNAImageParts[x].getImagePart(),
				"NoDNA_Graph_Image_"+to_string(x),"NO_DNA",rowPixelIntensityValues,this->secondTopBandIndex,this->lastBPPositionInLadder,myfile);

			if(noDNABandPositions.size() == 0) isNoDNAValid=true;
			else isNoDNAValid = false; 
		}

		//if no DNA column is valid proceed the process / else stop
		if(isNoDNAValid){			

			//If the image is for HD,SCA1,SCA2 and SCA3 check postive controller is ok
			if(positiveController.getDeseaseType() != ""){				

				this->maxIntensityCount = 0;

				vector<long> rowPixelIntensityValues = this->getIntensitiesAboveThreshold(positiveController.getImagePart(),this->intensityThreshold,0);

				myfile <<"\nPositive Controller Bands Positions"<<endl;

				vector<float> positiveControllerBandPositions = this->getSampleBandPositions(positiveController.getImagePart(),positiveController.getDeseaseType()+"Graph_Image_",positiveController.getDeseaseType(),rowPixelIntensityValues,this->secondTopBandIndex,this->lastBPPositionInLadder,myfile);

				if(positiveControllerBandPositions.size() == 2)
					this->isPositiveControllerValid=true;
			}
			columnsToBeCalculateBPValues = this->getColumnsToBeCalculatedBPValues(neededSegmentedImageParts,myfile);				

		}else		
			std::cout<<"Generate Error : Image is INVALID\n";
	}

	if(columnsToBeCalculateBPValues.size() > 0){

	ofstream sampleImageDataFile;	
	sampleImageDataFile.open ("F:\\Images\\4yr project pics\\Final project Images\\Image parts\\parts\\Calculated_Ladder_Sample_BP_Data.txt");

		for(ColumnObject columnObj:columnsToBeCalculateBPValues){

			if(columnObj.getColumnType().find("DMD") != std::string::npos||columnObj.getColumnType().find("CONTROLLER") != std::string::npos){
				columnDetails.push_back(columnObj);

			}else{
				columnObj = bpValueGeneration->calculateSampleBPValues(this->isLadder50BP,this->calculatedLadderBandPositions,columnObj,sampleImageDataFile);
				columnDetails.push_back(columnObj);
			}
		}	
		sampleImageDataFile.close();
	}
	
	myfile.close();	
	return columnDetails;
}

vector<ColumnObject> DNABandPositionExtraction::getColumnsToBeCalculatedBPValues(vector<SegmentedImagePart> neededSegmentedImageParts,std::ofstream &InputFile){

	vector<ColumnObject> columnsToBeCalculated;

	for(int i = 0;i <neededSegmentedImageParts.size(); i++){

		this->maxIntensityCount = 0;
		this->isSampleColumn=true;
		ColumnObject *co=new ColumnObject();

		string deseaseType=neededSegmentedImageParts[i].getDeseaseType();			
		this->trueDMD=false;
		this->trueHD=false;
		this->trueStroke=false;
		this->trueNegativeController=false;

		//check valid HD desease image
		if(this->isPositiveControllerValid && deseaseType.find("SCA") != std::string::npos || deseaseType =="HD")
			this->trueHD=true;

		//check valid DMD desease image			
		else if(deseaseType.find("DMD") != std::string::npos)
			this->trueDMD=true;

		//check valid Stroke desease image
		else if(deseaseType.find("ACE") != std::string::npos || deseaseType =="STROKE")
			this->trueStroke=true;

		//check type is a negative controller
		else if(deseaseType.find("(-)") != std::string::npos)
			this->trueNegativeController=true;

		else
			std::cout<<"Image Part Is inValid \n";

		if(this->trueDMD || this->trueHD || this->trueStroke || this->trueNegativeController){

			vector<long> rowPixelIntensityValues = this->getIntensitiesAboveThreshold(neededSegmentedImageParts[i].getImagePart(),this->intensityThreshold,0);

			vector<float> sampleBandPositions  = this->getSampleBandPositions(neededSegmentedImageParts[i].getImagePart(),to_string(i)+"_Sample_Graph_Image",deseaseType,rowPixelIntensityValues,this->secondTopBandIndex,this->lastBPPositionInLadder,InputFile);

			co->setPatientId(neededSegmentedImageParts[i].getPatientID());
			co->setColumnType(deseaseType);
			co->setBandPositions(sampleBandPositions);

			columnsToBeCalculated.push_back(*co);
		}
	}
	return columnsToBeCalculated;
}

vector<long> DNABandPositionExtraction::getIntensitiesAboveThreshold(Mat image,int thresholdIntensityValue,int startRow) {

	//store pixel count in the image rows
	vector<long> rowValues;

	//store sum of intensity values in a row
	long intensitySum;

	//horizontal histogram calculation
	for (int j = startRow; j < image.rows; j++)
	{
		intensitySum = 0;
		for (int i = 0; i < image.cols; i++)
		{
			int px=image.at<uchar>(j, i);
			if(px>=thresholdIntensityValue) intensitySum += px;
			//else image.at<uchar>(j, i)=0;
		}
		if (this->maxIntensityCount < intensitySum)
		{
			this->maxIntensityCount = intensitySum;
		}
		rowValues.push_back(intensitySum);
	}	
	return rowValues;
}

void DNABandPositionExtraction::getLadderBandPositions(String ladderType,Mat image,String name,
													   vector<long> rowValues,int topPixelIntensityCount,std::ofstream &InputFile){
	
	InputFile << ladderType + " : Ladder DNA Bands Data"<< endl;

	GelUtils *gUtils=new GelUtils();
	ColumnObject *co=new ColumnObject();

	co->setColumnType(ladderType);

	vector<long> rowPixelIntensityValuesBeforeUpdate; 
	int secondTopIntensityBandPosition,thirdTopIntensityBandPosition,maxIntensityBandIndex=0;
	vector<float> ladderBandPositions;	

	//store peak ladder band values with their row at level 1 
	std::map<int, int> ladderBandPositionsWithIntensities; 

	//Non maxima supression
	rowValues = gUtils->nonMaximaSupression(rowValues);	

	if(ladderType == "50 BP LADDER"){			

		//detect the top ladder band value
		bool topBandDetected=false; 

		for (int i = 0; i < rowValues.size(); i++) 
		{
			//at first this band value is equal to maxCount. so we pass it at first
			if(rowValues.at(i)==topPixelIntensityCount && !topBandDetected)
			{
				rowPixelIntensityValuesBeforeUpdate=rowValues;
				maxIntensityBandIndex=i;
				topBandDetected=true;
				break;			
			}
			else if(rowValues.at(i)!=topPixelIntensityCount && !topBandDetected) rowValues.at(i)=0;		
		}

		if(topBandDetected)		
			rowValues = this->getIntermediateLadderProcessing(ladderType,rowPixelIntensityValuesBeforeUpdate,maxIntensityBandIndex-1,rowValues.size()-1,InputFile);

	}else{

		this->isLadder50BP = false;
		rowPixelIntensityValuesBeforeUpdate = rowValues;

		//100 BP Ladder 
		InputFile <<" \nTop Two Bands Positions " << endl;

		rowValues = this->getIntermediateLadderProcessing(ladderType,rowValues,0,rowValues.size()-1,InputFile);
	}

	//create histogram to the ladder
	gUtils->drawHistogramWithAttachedToImage(image,name,rowValues,this->maxIntensityCount);
}

vector<long> DNABandPositionExtraction::getIntermediateLadderProcessing(String ladderType, vector<long> rowValues,
											int startingPos, int endingPos,std::ofstream &InputFile){

	GelUtils *gUtils=new GelUtils();
	ColumnObject *co=new ColumnObject();

	co->setColumnType(ladderType);

	//vector<long> rowPixelIntensityValuesBeforeUpdate; 
	int secondTopIntensityBandPosition,thirdTopIntensityBandPosition=0;
	vector<float> ladderBandPositions;	
	vector<std::pair<int, int>> top_Needed;

	//store peak ladder band values with their row at level 1 
	std::map<int, int> ladderBandPositionsWithIntensities; 

	//getting all peak positions between two given band positions
	ladderBandPositionsWithIntensities = gUtils->getPeakIntensityBandsBetweenTwoPositions(rowValues,startingPos,endingPos);

	vector<std::pair<int, int>> topElements = gUtils->findTopNumberOfIntensityBands(ladderBandPositionsWithIntensities,ladderBandPositionsWithIntensities.size());

	int x, startDecide, endDecide, neededBetweenPos = 0;

	InputFile <<" \nTop Bands Positions with Intensities" << endl;

	if(ladderType == "50 BP LADDER"){

		x = 0;
		startDecide = 0;
		endDecide = 0;
		neededBetweenPos=8;

		//check that the second and third intensity positions are valid and remove bad detections
		top_Needed = this->removeBadDetectionsInTopIntensityPositions(topElements,this->approximatedBandDistanceThreshold);

		vector<std::pair<int, int>> sortedTopThreeElements = gUtils->sortBykey(top_Needed);

		for (auto const& p: sortedTopThreeElements)
		{
			InputFile << p.first << " : "<< p.second << endl;

			x++;
			//std::cout << "{ " << p.first << ", " << p.second << "}";
			if(x==2) secondTopIntensityBandPosition = p.first;
			if(x==3) thirdTopIntensityBandPosition = p.first; 
		}

	}else{

		x=-1;
		startDecide = 5;
		endDecide = -1;
		neededBetweenPos = 5;

		top_Needed = gUtils->findTopNumberOfIntensityBands(ladderBandPositionsWithIntensities,2);		
		vector<std::pair<int, int>> sortedTopTwo = gUtils->sortBykey(top_Needed);

		for (auto const& p: sortedTopTwo)
		{
			x++;
			InputFile << p.first << " : "<< p.second << endl;

			if(x==0) secondTopIntensityBandPosition = p.first;
			if(x==1) thirdTopIntensityBandPosition = p.first; 
		}
	}

	ladderBandPositions.push_back(secondTopIntensityBandPosition);
	ladderBandPositions.push_back(thirdTopIntensityBandPosition);

	this->secondTopBandIndex = secondTopIntensityBandPosition;

	//getting bandpositions between second and third 		
	std::map<int, int> bandPositionsBetweenSecondAndThird = gUtils->getPeakIntensityBandsBetweenTwoPositions(rowValues, secondTopIntensityBandPosition + startDecide,thirdTopIntensityBandPosition + endDecide);

	//find intensity bands between given two positions
	std::vector<std::pair<int, int>> top_NeededBetweenPositions = gUtils->findTopNumberOfIntensityBands(bandPositionsBetweenSecondAndThird,neededBetweenPos);
	vector<std::pair<int, int>> sortedTopElements = gUtils->sortBykey(top_NeededBetweenPositions);

	InputFile <<"\nBand Positions Between Second and Third Top Intensities" << endl;

	//setting peakPositions to the Column Object
	for(pair<int,int> p : sortedTopElements){
		InputFile <<"{ " << p.first << ", " << p.second << "}"<< endl;
		ladderBandPositions.push_back(p.first);
	}

	//add peak band positions to the ColumnObject
	co->setBandPositions(ladderBandPositions);

	this->calculatedLadderBandPositions = this->getCalculatedLadderPositions(*co);

	std::vector<std::pair<int, int>> allPeakPositions;

	if(ladderType == "50 BP LADDER")	
		this->lastBPPositionInLadder=this->calculatedLadderBandPositions[this->calculatedLadderBandPositions.size()-1];	
	else
		this->lastBPPositionInLadder=rowValues.size()-1;

	allPeakPositions = gUtils->mergeTwoPairVectors(top_Needed,sortedTopElements);	

	//sort all peak positions
	vector<std::pair<int, int>> sortedAllPeakPositions = gUtils->sortBykey(allPeakPositions);

	//keep only the peakValues in the rows
	rowValues = gUtils->removeAllNonPeakPositionsWithinImage(sortedAllPeakPositions,rowValues);

	return rowValues;
}

vector<float> DNABandPositionExtraction::getSampleBandPositions(Mat image,String name,String deseaseType,vector<long> rowValues,int startingPoint,int endingPoint,std::ofstream &InputFile)
{	
	GelUtils *gUtils=new GelUtils();
	vector<float> samplePeakPositions;	

	//clear rowValuesBeforeChange when starting process with each column
	this->rowValuesBeforeChange.clear();

	float mean=gUtils->getMeanWithinRange(startingPoint,endingPoint,rowValues);

	//Non maxima supression
	rowValues = gUtils->nonMaximaSupression(rowValues);

	std::map<int, int> sampleBandPositions; //store sample band values with their row  
	//bool secondBandPointDetected=false; //detect the second band value position from the sample columns
	bool startDetected=false;
	//int bandVal=rowValues.at(startingPoint); 

	if(deseaseType.find("ACE") != std::string::npos || deseaseType =="STROKE"){

		startDetected = this->isStartingPositionDetected(rowValues,startingPoint,rowValues.size());	

	}else{

		for (int i = this->lastBPPositionInLadder+1; i < rowValues.size(); i++) 
		{
			rowValues.at(i)=0;
		}

		startDetected = this->isStartingPositionDetected(rowValues,startingPoint,this->lastBPPositionInLadder+1);		
	}	

	if(startDetected)
	{
		//update max intensity count inside this
		this->maxIntensityCount=0;

		vector<long> rowPixelIntensityValues = this->getIntensitiesAboveThreshold(image,this->intensityThreshold,startingPoint);

		rowValues=gUtils->removeIntensitiesLowerThanMean(startingPoint,endingPoint,rowValues,mean);

		std::map<int, int> levelOnePeakPositions = gUtils->getPeakIntensityBandsBetweenTwoPositions(rowValues, startingPoint,endingPoint);

		////getting peaks in level 1
		std::vector<std::pair<int, int>> topElements = gUtils->findTopNumberOfIntensityBands(levelOnePeakPositions,levelOnePeakPositions.size());
		
		////sort all level 1 peak positions
		vector<std::pair<int, int>> sortedLevelOnePeakPositions = gUtils->sortBykey(topElements);

		//deal with NO DNA Column and check the current column is NO DNA Column
		if(!this->isNoDNAColumnChecked || this->isSampleColumn){

			this->isNoDNAColumnChecked=true;			
			int count=0;

			for(auto const& p: sortedLevelOnePeakPositions){		
				if(p.second > this->columnValidityRatio*this->maxIntensityCount) count++;		
			}

			if(count >= this->columnValidityThreshold){ 
				rowValues.clear();
				gUtils->drawHistogramWithAttachedToImage(image,name,rowValues,this->maxIntensityCount);
				return samplePeakPositions;
			}
		}

		if(deseaseType == "(+) CONTROLLER"){			
			//no need to take level two peaks

			std::vector<std::pair<int, int>> topTwo = gUtils->findTopNumberOfIntensityBands(levelOnePeakPositions,2);
			vector<std::pair<int, int>> sortedLevelOneControllerPeaks = gUtils->sortBykey(topTwo);

			//setting peakPositions to the Column Object in sample column
			for(pair<int,int> p : sortedLevelOneControllerPeaks){
				InputFile <<"{"<< p.first <<" : "<< p.second <<"}"<<endl;
				samplePeakPositions.push_back(p.first);
			}

			//keep only the peakValues in the rows
			rowValues = gUtils->removeAllNonPeakPositionsWithinImage(sortedLevelOneControllerPeaks,rowValuesBeforeChange);			

		}	

		else if(this->trueHD || this->trueStroke){
			//no need to take level two peaks				

			std::vector<std::pair<int, int>> topTwo = gUtils->findTopNumberOfIntensityBands(levelOnePeakPositions,2);

			vector<std::pair<int, int>> sortedLevelOneControllerPeaks = gUtils->sortBykey(topTwo);
			
			vector<std::pair<int, int>> selectedSortedPeaks = sortedLevelOneControllerPeaks;

			InputFile <<"\n"<< deseaseType << endl;							
			int x = -1;

			//setting peakPositions to the Column Object in sample column
			for(pair<int,int> p : sortedLevelOneControllerPeaks){					

				x++;
				if(p.second >= this->maxIntensityCount * this->stokeBandLenthRatio){
					InputFile <<"{"<< p.first <<" : "<< p.second <<"}"<<endl;
					samplePeakPositions.push_back(p.first);
				}else{
					selectedSortedPeaks.erase(selectedSortedPeaks.begin()+x);					
				}				
			}

			sortedLevelOneControllerPeaks = selectedSortedPeaks;

			//keep only the peakValues in the rows
			rowValues = gUtils->removeAllNonPeakPositionsWithinImage(sortedLevelOneControllerPeaks,rowValuesBeforeChange);			

		}else{

			//if the desease type is DMD only comes here
			InputFile <<"\n"<< deseaseType << endl;

			//getting peaks in level 2
			vector<std::pair<int, int>> levelTwoPeakPositions = this->getLevel2Peaks(sortedLevelOnePeakPositions,rowValuesBeforeChange);

			//merge two vectors
			std::vector<std::pair<int, int>> allPeakPositions = gUtils->mergeTwoPairVectors(sortedLevelOnePeakPositions,levelTwoPeakPositions);	

			if(this->trueNegativeController){

				std::map<int, int> peaksOfMap;

				for(auto const& p: allPeakPositions){				
					peaksOfMap.insert(p);
				}

				if(deseaseType=="(-) CONTROLLER_C"|| deseaseType=="(-) CONTROLLER_B")
					allPeakPositions = gUtils->findTopNumberOfIntensityBands(peaksOfMap,5);

				else if(deseaseType=="(-) CONTROLLER_A"|| deseaseType=="(-) CONTROLLER_D")
					allPeakPositions = gUtils->findTopNumberOfIntensityBands(peaksOfMap,4);			

				else
					allPeakPositions = gUtils->findTopNumberOfIntensityBands(peaksOfMap,1);				
			}

			//sort all peak positions
			vector<std::pair<int, int>> sortedAllPeakPositions = gUtils->sortBykey(allPeakPositions);

			//setting peakPositions to the Column Object in sample column
			for(pair<int,int> p : sortedAllPeakPositions){
				InputFile <<"{"<< p.first <<" : "<< p.second <<"}"<<endl;
				samplePeakPositions.push_back(p.first);
			}

			//keep only the peakValues in the rows
			rowValues = gUtils->removeAllNonPeakPositionsWithinImage(sortedAllPeakPositions,rowValuesBeforeChange);
		}		
	}

	//create histogram to the sample band columns
	gUtils->drawHistogramWithAttachedToImage(image,deseaseType + name,rowValues,this->maxIntensityCount);

	//std::cout << '\n';	
	return samplePeakPositions;
}

bool DNABandPositionExtraction::isStartingPositionDetected(vector<long> rowValues,int requiredStartingPoint,int loopEndingPosition){

	bool secondBandPointDetected=false; //detect the second band value position from the sample columns
	bool startingPointDetected=false;
	int bandVal=rowValues.at(requiredStartingPoint); 
	
		for (int i = 0; i < loopEndingPosition; i++) 
		{	
			if(i==requiredStartingPoint && !secondBandPointDetected) secondBandPointDetected=true;

			if(!secondBandPointDetected) rowValues.at(i)=0;

			if(rowValues.at(i) > bandVal && !startingPointDetected) 
			{
				this->rowValuesBeforeChange=rowValues;
				startingPointDetected=true;
				break;
			}

			if(secondBandPointDetected && !startingPointDetected) rowValues.at(i)=0;
		}
		return startingPointDetected;
}

vector<float> DNABandPositionExtraction:: getCalculatedLadderPositions(ColumnObject ladderObject){

	ColumnObject *co=new ColumnObject();
	BPValueGeneration *bpValueGeneration=new BPValueGeneration();
	*co = bpValueGeneration->calculateLadderBPValues(ladderObject);	
	return co->getBandPositions();
}

vector<std::pair<int, int>> DNABandPositionExtraction:: removeBadDetectionsInTopIntensityPositions
	(vector<std::pair<int, int>> topElements,int bandDistanceThreshold)
{
	vector<std::pair<int, int>> top_three;
	int x=-1;
	int temp;
	temp=topElements[0].first;
	top_three.push_back(topElements[0]);

	for(pair<int,int> p:topElements){
		x++;
		if(x > 0){
			if((p.first-temp)>bandDistanceThreshold||(temp-p.first)>bandDistanceThreshold){
				temp = p.first;
				top_three.push_back(p);
				if(top_three.size()==3) break;
			}
		}
	}
	return top_three;
}

std::vector<std::pair<int, int>> DNABandPositionExtraction::getLevel2Peaks(vector<std::pair<int, int>> topElements,vector<long> rowValues){

	std::vector<std::pair<int, int>> level2PeakPositions;

	int count=0;
	int x=-1;

	for(auto const& p: topElements){
		count=0;
		x++;
		int peakPoint=p.first;
		int peakLength=p.second;
		int previous=peakLength;

		for(int i = peakPoint + 1; i < rowValues.size(); i++){	

			if(rowValues.at(i)!=0){

				int current=rowValues.at(i);

				//current length should lower than the previos length and the peak length
				if(current > this->ratioOfLength * peakLength && current < peakLength && current < previous){
					count++;	
					previous=rowValues.at(i);

					if(count==this->numberOfAboveBands){
						std::pair<int, int> p1(i, rowValues.at(i));
						//take the position as new peak
						level2PeakPositions.push_back(p1);
					}

				}else break;

			}			
		}
	}
	return level2PeakPositions;
}

bool DNABandPositionExtraction::checkColumnContainAnyBands(Mat image,string name,vector<long> rowValues){

	//this->isNoDNAColumnChecked=true;
	GelUtils *gUtils=new GelUtils();	

	float mean=gUtils->getMeanWithinRange(0,rowValues.size()-1,rowValues);

	//Non maxima supression
	rowValues = gUtils->nonMaximaSupression(rowValues);

	//update max intensity count inside this
	this->maxIntensityCount=0;
	vector<long> rowPixelIntensityValues = this->getIntensitiesAboveThreshold(image,this->intensityThreshold,0);

	rowValues=gUtils->removeIntensitiesLowerThanMean(0,rowValues.size()-1,rowValues,mean);

	std::map<int, int> levelOnePeakPositions = gUtils->getPeakIntensityBandsBetweenTwoPositions(rowValues,0,rowValues.size()-1);

	//getting peaks in level 1
	std::vector<std::pair<int, int>> topElements = gUtils->findTopNumberOfIntensityBands(levelOnePeakPositions,levelOnePeakPositions.size());

	//sort all level 1 peak positions
	vector<std::pair<int, int>> sortedLevelOnePeakPositions = gUtils->sortBykey(topElements);

	int count = 0;

	for(auto const& p: sortedLevelOnePeakPositions){		
		if(p.second > this->columnValidityRatio*this->maxIntensityCount) count++;		
	}

	if(count >= this->columnValidityThreshold){ 
		rowValues.clear();
		gUtils->drawHistogramWithAttachedToImage(image,name,rowValues,this->maxIntensityCount);
		return true;
	}

	rowValues=gUtils->removeAllNonPeakPositionsWithinImage(sortedLevelOnePeakPositions,rowValues);

	//create histogram to the sample band columns
	gUtils->drawHistogramWithAttachedToImage(image,name,rowValues,this->maxIntensityCount);

	return false;
}