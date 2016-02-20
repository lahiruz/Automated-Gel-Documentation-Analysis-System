#include "BPValueGeneration.h"
#include "ColumnObject.h"
#include "GelUtils.h"
#include "opencv\cv.h"
#include "opencv\highgui.h"
#include <numeric>
#include <functional>
#include <fstream>
#include <vector>
#include <algorithm>
#include <iterator>
#include <iostream>

BPValueGeneration::BPValueGeneration(void)
{
}

BPValueGeneration::~BPValueGeneration(void)
{
}

ColumnObject BPValueGeneration::calculateLadderBPValues(ColumnObject ladderObject){	

	ColumnObject *co=new ColumnObject();
	co->setPatientId(ladderObject.getPatientId());
	co->setColumnType(ladderObject.getColumnType());

	std::vector<float> arr_of_BP;
	bool is50BP = false;
	int ladderDistanceThreshold=0;

	if(ladderObject.getColumnType() == "50 BP LADDER"){

		is50BP = true;
		ladderDistanceThreshold = 665;		

		static const int arr50BP[] = {0,66,112,176,239,311,388,474,565,665,796,929,1091,1270,1470,1699};
		vector<int> referenceLadderValuesIn50BP (arr50BP, arr50BP + sizeof(arr50BP) / sizeof(arr50BP[0]) );

		arr_of_BP = this->calculateRelatedLadderPositions(ladderObject,referenceLadderValuesIn50BP,ladderDistanceThreshold,is50BP);

	}else{

		ladderDistanceThreshold = 443;

		//static const int arr100BP[] = {0,81,121,127,151,180,202,230,265,450};
		static const int arr100BP[] = {0,68,139,224,327,443,573,726,910,1131};
		vector<int> referenceLadderValuesIn100BP (arr100BP, arr100BP + sizeof(arr100BP) / sizeof(arr100BP[0]) );

		arr_of_BP = this->calculateRelatedLadderPositions(ladderObject,referenceLadderValuesIn100BP,ladderDistanceThreshold,is50BP);

	}

	co->setBandPositions(arr_of_BP);	
	return *co;

}


std::vector<float> BPValueGeneration::calculateRelatedLadderPositions(ColumnObject ladderObj,vector<int> referenceLadderValuesInBP,int distance,bool is50BP){

	ofstream ladderFile;	
	ladderFile.open ("F:\\Images\\4yr project\\ProcessedImageData\\Calculated_Ladder_Reference_BP_Data.txt");
	ladderFile<<"Ladder Type : "<< ladderObj.getColumnType() << "\n" <<endl;

	std::vector<float> bp_Vals;

	int num_elements = referenceLadderValuesInBP.size();

	// calculate and push first initial ladder value in to array
	float BP_800_Or_1000 = ladderObj.getBandPositions()[0] + ((0) / distance)*(ladderObj.getBandPositions()[1] - ladderObj.getBandPositions()[0]);
	bp_Vals.push_back(BP_800_Or_1000);

	if(is50BP)
		ladderFile <<"{800 : " << BP_800_Or_1000 <<"}"<< endl;
	else
		ladderFile <<"{1000 : " << BP_800_Or_1000 <<"}"<< endl;

	//calculate and push other all initial ladder values in to array
	for (int x = 0; x < num_elements-1; x++)
	{
		//calculation
		float calculation_BP = (referenceLadderValuesInBP[x + 1] - referenceLadderValuesInBP[x]);
		calculation_BP = calculation_BP / distance;
		calculation_BP = calculation_BP*(ladderObj.getBandPositions()[1] - ladderObj.getBandPositions()[0]);
		calculation_BP = (bp_Vals[x] + calculation_BP);
		//push data 

		if(is50BP)
			ladderFile <<"{"<< 750 - (50*x) <<" : " << calculation_BP <<"}"<< endl;
		else
			ladderFile <<"{"<< 900 - (100*x) <<" : " << calculation_BP <<"}"<< endl;

		bp_Vals.push_back(calculation_BP);
	}

	ladderFile.close();
	return bp_Vals;

}

ColumnObject BPValueGeneration::calculateSampleBPValues(bool isLadder50BP,vector<float> calculatedLadderBPPositions,ColumnObject foundedSampleBandPositions,std::ofstream &sampleDataFile){

	sampleDataFile <<"\n"<< foundedSampleBandPositions.getColumnType() << endl;

	ColumnObject calculatedValues;			
	float BP_val_new = 0;
	float BP_val_previous = 0;
	vector<float> tempBPValues;
	ColumnObject *co = new ColumnObject();
	
	co->setPatientId(foundedSampleBandPositions.getPatientId());
	co->setColumnType(foundedSampleBandPositions.getColumnType());

	int getColumnBandPositionSize = foundedSampleBandPositions.getBandPositions().size();
	int num_elements_arr_of_BP = calculatedLadderBPPositions.size();	
	int start = 0;
	int distanceBetweenTwo = 0;

	if(isLadder50BP){

		start = 800;
		distanceBetweenTwo = 50;

	}else{

		start = 1000;
		distanceBetweenTwo = 100;

	}

	for (int z = 0; z < getColumnBandPositionSize; z++)
	{
		if (foundedSampleBandPositions.getBandPositions()[z] > 0)
		{
			if (foundedSampleBandPositions.getBandPositions()[z] <= calculatedLadderBPPositions[0])
			{
				float ValueDetail=foundedSampleBandPositions.getBandPositions()[z];
				ValueDetail = 0;					
			}
			else if (foundedSampleBandPositions.getBandPositions()[z] > calculatedLadderBPPositions[num_elements_arr_of_BP-1])
				foundedSampleBandPositions.getBandPositions()[z] = 0;
			else
			{
				for (int y = 0; y <= num_elements_arr_of_BP; y++)
				{
					float xz = start - y * distanceBetweenTwo;
					float yz = xz + distanceBetweenTwo;
					if (foundedSampleBandPositions.getBandPositions()[z] <= calculatedLadderBPPositions[y])
					{			
						BP_val_new = calculatedLadderBPPositions[y];
						BP_val_previous = calculatedLadderBPPositions[y - 1];
						if (BP_val_new > 0)
						{
							float x2 = BP_val_new;
							float x3 = BP_val_previous;
							float difference_of_pixel = x2 - x3;
							float BP_calculation = distanceBetweenTwo / difference_of_pixel;	
							float new_BP_calculation = BP_calculation * (x3 - foundedSampleBandPositions.getBandPositions()[z] );
							float final_BP_calculation = yz + new_BP_calculation ;
							int i_val= (int)final_BP_calculation;			
							tempBPValues.push_back(i_val);
							sampleDataFile <<"{ Calculated Base Pair Value -> : " << i_val <<"}"<< endl;				
							break;
						}
					}
				}				
			}
		}
	}

	co->setBandPositions(tempBPValues);
	return *co;
}