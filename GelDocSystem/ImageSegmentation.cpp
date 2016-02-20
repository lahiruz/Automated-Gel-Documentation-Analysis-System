#include "ImageSegmentation.h"
#include "SegmentedImagePart.h"
#include "GelUtils.h"
#include "DNABandPositionExtraction.h"
#include "ColumnObject.h"

ImageSegmentation::ImageSegmentation(void)
{
	this->bandIdentificationCount = 0;
	dnaBandPositionExtraction=new DNABandPositionExtraction();
}

ImageSegmentation::~ImageSegmentation(void)
{
}

char* ImageSegmentation::extractImageData(char* imagePath,char* ImageData){

	vector<SegmentedImagePart> segmentedImageDetails= this->getSegmentedImageDetails(imagePath,ImageData);	
	vector<ColumnObject> columnDetails=dnaBandPositionExtraction->getFinallyExtractedImageColumnData(segmentedImageDetails);
	
	char* stringColumnData=this->columnDetailsAsString(columnDetails);

	return stringColumnData;

}

char* ImageSegmentation ::columnDetailsAsString(vector<ColumnObject> columnDetails){

	std::string finalString ;

	for (int SizeOfcolumnDetails = 0; SizeOfcolumnDetails < columnDetails.size(); SizeOfcolumnDetails++)
	{
		string Deseace_Values[] = {"DMD A","DMD B","DMD C","DMD D","DMD E","DMD F","HD","SCA1","SCA2","SCA3","STROKE"};
		string Controller_Values[] = {"(-) CONTROLLER_A","(-) CONTROLLER_B","(-) CONTROLLER_C","(-) CONTROLLER_D","(-) CONTROLLER_E","(-) CONTROLLER_F"};
		int ValueOfDeseace_Values=sizeof(Deseace_Values) / sizeof(Deseace_Values[0]);
		int ValueOfController_Values=sizeof(Controller_Values) / sizeof(Controller_Values[0]);

		for (int x = 0; x < ValueOfDeseace_Values; x++)
		{
			if (columnDetails[SizeOfcolumnDetails].getColumnType()== Deseace_Values[x])
			{
				string A=columnDetails[SizeOfcolumnDetails].getPatientId();

				for (int SizeOfEachValue = 0; SizeOfEachValue < columnDetails.size(); SizeOfEachValue++)
				{
					if ( x < 6)
					{
						if (columnDetails[SizeOfEachValue].getColumnType() == Controller_Values[x])
						{
							std::string str;
							std::string app ;				

							for(int a=0; a < columnDetails[SizeOfcolumnDetails].getBandPositions().size();a++){

								if (a==columnDetails[SizeOfcolumnDetails].getBandPositions().size()-1)								
									str.append(to_string(columnDetails[SizeOfcolumnDetails].getBandPositions()[a]));								
								else								
									str.append(to_string(columnDetails[SizeOfcolumnDetails].getBandPositions()[a])+",");								
							}

							for(int a=0; a < columnDetails[SizeOfEachValue].getBandPositions().size();a++){

								if (a==columnDetails[SizeOfEachValue].getBandPositions().size()-1)								
									app.append(to_string(columnDetails[SizeOfEachValue].getBandPositions()[a]));								
								else								
									app.append(to_string(columnDetails[SizeOfEachValue].getBandPositions()[a])+",");
							}

							string columnDetailsValue=columnDetails[SizeOfcolumnDetails].getPatientId() + ":" + columnDetails[SizeOfcolumnDetails].getColumnType() + ":"+ str+":"+app;					

							finalString = finalString.append(columnDetailsValue + "|");
						}
					}
				}
			}
		}
	}
	
	finalString = finalString.substr(0, finalString.size()-1);
	char *dataAsCharArray = new char[finalString.length() + 1];
	strcpy(dataAsCharArray, finalString.c_str());

	return dataAsCharArray;
}

//crop the image borders
vector<SegmentedImagePart> ImageSegmentation :: getIntensityGraphs(vector<SegmentedImagePart> imageData,Mat image,String name)
{  
	//store pixel count in the image columns
	vector<long> colValues;

	//store sum of intensity values in a row
	long intensitySum;	
	long startPoint = 0;
	long endPoint = 0;
	long startValue = 0;

	//max intensity pixel count encountered
	double maxcount = 0;

	vector<int> lineHeights;

	pyrDown(image, image);

	Mat histimage(image.rows + 300, image.cols + 300, CV_8UC3, Scalar(0));

	//verticle histogram calculation
	for (int i = 0; i < image.cols; i++)
	{
		intensitySum = 0;

		for (int j = 0; j < image.rows; j++)
		{
			int px=image.at<uchar>(j, i);
			if(px>=140)intensitySum += px;

		}

		if (maxcount < intensitySum)
		{
			maxcount = intensitySum;
		}

		colValues.push_back(intensitySum);

	}

	//vector<SegmentedImagePart> dataObject = getUserInputs();

	if (colValues[0] < 2000)
	{
		int x = 0;
		int y = 0;
		imageData = this->imageCroping(imageData,x, y, image);
	}

	//remove the reflect part of the image
	else
	{		
		int count =0;
		for (int i = 0; i < colValues.size(); i++)
		{	
			if(colValues[i] > 2000){
				if(count == 0) startPoint = i;

				count++;

				if (!(count < 40)) break;

			}else count = 0;
		}	

		Mat testImage(image.rows,image.cols-startPoint,CV_8UC1); 
		for (int i = startPoint; i < image.cols; i++){   
			for (int j = 0; j < image.rows; j++){
				testImage.at<uchar>(j,i-startPoint)=image.at<uchar>(j,i);
			}
		}

		//namedWindow("Testing_Image");
		//imshow("Testing_Image",testImage);
		//imwrite("F:\\Project\\test\\testnew.jpg",testImage); 

		//crop the image
		int x = 0;
		int y = 0;
		imageData = this->imageCroping(imageData,x, y, testImage);
	}

	//draw verticle histogram
	for (int i = 0; i < colValues.size(); i++) {

		line(histimage, Point(i + 300, 300),Point(i + 300, 300-cvRound((colValues.at(i) / maxcount) * 300)), Scalar(0, 255, 0), 1, 8, 0);
		//printf("%d\n", colValues[i]);
	}

	cvtColor(image, image, CV_GRAY2BGR);
	cv::Rect roi(cv::Point(300, 300), image.size());
	image.copyTo(histimage(roi));

	//namedWindow(name);
	//imshow(name, histimage);    
	//imwrite("E:\\Project\\test\\testHistogrm.jpg",histimage);    

	return imageData;
}

//add image part to the object
vector<SegmentedImagePart> ImageSegmentation::storeImagePart(vector<SegmentedImagePart> Data, Mat image,int start, int dna, int num){
	Mat imagePart(image.rows,dna,CV_8UC1);	
	imagePart=image( Rect(start,0,dna,image.rows));
	Data[num].setImagePart(imagePart);
	imwrite("F:\\Images\\4 Year Project\\ProcessedImageData\\Segmented_ImageParts\\" +std::to_string(num)+".jpg",imagePart);

	return Data;
}

//image part cropping method
vector<SegmentedImagePart> ImageSegmentation::imageCroping(vector<SegmentedImagePart> imageData,int startPoint, int endPoint, Mat image){

	vector<long> intensityValues;
	vector<float> testVector;
	int sum;
	int dnaBandWidth = 0;
	int widthOfTwoBands = 0;
	int parameter = 0;

	for (int i = 0; i < image.cols; i++)
	{
		sum = 0;
		for (int j = 0; j < image.rows; j++)
		{
			int px=image.at<uchar>(j, i);
			if(px>=140) sum += px;            	            
		}
		
		intensityValues.push_back(sum);
	}	

	//identify the DNA colums
	for (int i = startPoint; i < intensityValues.size(); i++)
	{		
		if (intensityValues[i] == 0) break;		

		dnaBandWidth++;
	}

	//identify the width between two bands
	int widthStartPoint = startPoint + dnaBandWidth;
	for (int i = widthStartPoint; i < intensityValues.size(); i++)
	{
		if (intensityValues[i] > 1350) break;

		widthOfTwoBands++;
	}

	//crop the DNA bands
	Mat imagePart(image.rows,dnaBandWidth,CV_8UC1);

	if (dnaBandWidth > 30 && dnaBandWidth <= 119)		
		imageData = storeImagePart(imageData, image, startPoint,dnaBandWidth, this->bandIdentificationCount);	

	else if (dnaBandWidth >= 120 && dnaBandWidth <= 201)
	{
		int divideDnaBandwidth = dnaBandWidth/2;
		dnaBandWidth = divideDnaBandwidth;

		imageData = storeImagePart(imageData, image, startPoint,dnaBandWidth, this->bandIdentificationCount);

		startPoint = startPoint + dnaBandWidth;
		this->bandIdentificationCount = this->bandIdentificationCount + 1;
		imageData = storeImagePart(imageData, image, startPoint,dnaBandWidth, this->bandIdentificationCount);

	}

	else if (dnaBandWidth >= 202 && dnaBandWidth <= 287 )
	{
		int divideDnaBandwidth = dnaBandWidth/3;
		dnaBandWidth = divideDnaBandwidth;

		imageData = storeImagePart(imageData, image, startPoint,dnaBandWidth, this->bandIdentificationCount);	

		for (int i = 0; i < 2; i++)
		{
			startPoint = startPoint + dnaBandWidth;
			this->bandIdentificationCount = this->bandIdentificationCount + 1;
			imageData = storeImagePart(imageData, image, startPoint,dnaBandWidth, this->bandIdentificationCount);

		}			
	}

	else if (dnaBandWidth >= 288 && dnaBandWidth <= 372 )
	{
		int divideDnaBandwidth = dnaBandWidth/4;
		dnaBandWidth = divideDnaBandwidth;

		imageData = storeImagePart(imageData, image, startPoint,dnaBandWidth, this->bandIdentificationCount);	

		for (int i = 0; i < 3; i++)
		{
			startPoint = startPoint + dnaBandWidth;
			this->bandIdentificationCount = this->bandIdentificationCount + 1;
			imageData = storeImagePart(imageData, image, startPoint,dnaBandWidth, this->bandIdentificationCount);

		}			
	}

	if (dnaBandWidth >= 460 && dnaBandWidth <= 545 )
	{
		int divideDnaBandwidth = dnaBandWidth/6;
		dnaBandWidth = divideDnaBandwidth;

		imageData = storeImagePart(imageData, image, startPoint,dnaBandWidth, this->bandIdentificationCount);		

		for (int i = 0; i < 5; i++)
		{
			startPoint = startPoint + dnaBandWidth;
			this->bandIdentificationCount = this->bandIdentificationCount + 1;
			imageData = storeImagePart(imageData, image, startPoint,dnaBandWidth, this->bandIdentificationCount);

		}			
	}	

	//crop the low intensity colums
	if (widthOfTwoBands > 40 && widthOfTwoBands <= 120)
	{	
		if (dnaBandWidth < 30) this->bandIdentificationCount = this->bandIdentificationCount;
		else this->bandIdentificationCount = this->bandIdentificationCount+1;		

		startPoint = startPoint + dnaBandWidth;
		imageData = storeImagePart(imageData, image, startPoint,widthOfTwoBands, this->bandIdentificationCount);	

		parameter++;		
	}

	else if (widthOfTwoBands > 121 && widthOfTwoBands <= 231)
	{
		if (dnaBandWidth < 30) this->bandIdentificationCount = this->bandIdentificationCount;
		else this->bandIdentificationCount = this->bandIdentificationCount+1;

		int divideWidthOfTwoBands = widthOfTwoBands/2;
		widthOfTwoBands = divideWidthOfTwoBands;

		startPoint = startPoint + dnaBandWidth;		
		imageData = storeImagePart(imageData, image, startPoint,widthOfTwoBands, this->bandIdentificationCount);		

		startPoint = startPoint + widthOfTwoBands;
		this->bandIdentificationCount = this->bandIdentificationCount + 1;

		imageData = storeImagePart(imageData, image, startPoint,widthOfTwoBands, this->bandIdentificationCount);
		parameter++;

	}

	else if (widthOfTwoBands >= 232 && widthOfTwoBands <= 288)
	{
		if (dnaBandWidth < 30) this->bandIdentificationCount = this->bandIdentificationCount;
		else this->bandIdentificationCount = this->bandIdentificationCount+1;

		int divideWidthOfTwoBands = widthOfTwoBands/3;
		widthOfTwoBands = divideWidthOfTwoBands;

		startPoint = startPoint + dnaBandWidth;
		imageData = storeImagePart(imageData, image, startPoint,widthOfTwoBands, this->bandIdentificationCount);		

		for (int i = 0; i < 2; i++)
		{
			startPoint = startPoint + widthOfTwoBands;
			this->bandIdentificationCount = this->bandIdentificationCount + 1;
			imageData = storeImagePart(imageData, image, startPoint,widthOfTwoBands, this->bandIdentificationCount);

		}	
		parameter++;

	}

	else if (widthOfTwoBands >= 289 && widthOfTwoBands <= 374)
	{
		if (dnaBandWidth < 30) this->bandIdentificationCount = this->bandIdentificationCount;
		else this->bandIdentificationCount = this->bandIdentificationCount+1;

		int divideWidthOfTwoBands = widthOfTwoBands/4;
		widthOfTwoBands = divideWidthOfTwoBands;

		startPoint = startPoint + dnaBandWidth;
		imageData = storeImagePart(imageData, image, startPoint,widthOfTwoBands, this->bandIdentificationCount);	

		for (int i = 0; i < 3; i++)
		{
			startPoint = startPoint + widthOfTwoBands;
			this->bandIdentificationCount = this->bandIdentificationCount + 1;
			imageData = storeImagePart(imageData, image, startPoint,widthOfTwoBands, this->bandIdentificationCount);

		}			
		parameter++;
	}

	else if (widthOfTwoBands >= 375 && widthOfTwoBands <= 460)
	{
		if (dnaBandWidth < 30) this->bandIdentificationCount = this->bandIdentificationCount;
		else this->bandIdentificationCount = this->bandIdentificationCount+1;

		int divideWidthOfTwoBands = widthOfTwoBands/5;
		widthOfTwoBands = divideWidthOfTwoBands;

		startPoint = startPoint + dnaBandWidth;
		imageData = storeImagePart(imageData, image, startPoint,widthOfTwoBands, this->bandIdentificationCount);		

		for (int i = 0; i < 4; i++)
		{
			startPoint = startPoint + widthOfTwoBands;
			this->bandIdentificationCount = this->bandIdentificationCount + 1;
			imageData = storeImagePart(imageData, image, startPoint,widthOfTwoBands, this->bandIdentificationCount);

		}			
		parameter++;
	}

	else if (widthOfTwoBands >= 461 && widthOfTwoBands <=546)
	{
		if (dnaBandWidth < 30) this->bandIdentificationCount = this->bandIdentificationCount;
		else this->bandIdentificationCount = this->bandIdentificationCount+1;

		int divideWidthOfTwoBands = widthOfTwoBands/6;
		widthOfTwoBands = divideWidthOfTwoBands;

		startPoint = startPoint + dnaBandWidth;
		imageData = storeImagePart(imageData, image, startPoint,widthOfTwoBands, this->bandIdentificationCount);		

		for (int i = 0; i < 5; i++)
		{
			startPoint = startPoint + widthOfTwoBands;
			this->bandIdentificationCount = this->bandIdentificationCount+1;
			imageData = storeImagePart(imageData, image, startPoint,widthOfTwoBands, this->bandIdentificationCount);			

		}

		parameter++;
	}

	else if (widthOfTwoBands >= 547 && widthOfTwoBands <=632)
	{
		if (dnaBandWidth < 30) this->bandIdentificationCount = this->bandIdentificationCount;
		else this->bandIdentificationCount = this->bandIdentificationCount+1;

		int divideWidthOfTwoBands = widthOfTwoBands/7;
		widthOfTwoBands = divideWidthOfTwoBands;

		startPoint = startPoint + dnaBandWidth;
		imageData = storeImagePart(imageData, image, startPoint,widthOfTwoBands, this->bandIdentificationCount);		

		for (int i = 0; i < 6; i++)
		{
			startPoint = startPoint + widthOfTwoBands;
			this->bandIdentificationCount = this->bandIdentificationCount+1;
			imageData = storeImagePart(imageData, image, startPoint,widthOfTwoBands, this->bandIdentificationCount);			

		}

		parameter++;
	}

	else if (widthOfTwoBands >= 633)
	{
		if (dnaBandWidth < 30) this->bandIdentificationCount = this->bandIdentificationCount;
		else this->bandIdentificationCount = this->bandIdentificationCount+1;

		int divideWidthOfTwoBands = widthOfTwoBands/8;
		widthOfTwoBands = divideWidthOfTwoBands;

		startPoint = startPoint + dnaBandWidth;
		imageData = storeImagePart(imageData, image, startPoint,widthOfTwoBands, this->bandIdentificationCount);		

		for (int i = 0; i < 7; i++)
		{
			startPoint = startPoint + widthOfTwoBands;
			this->bandIdentificationCount = this->bandIdentificationCount+1;
			imageData = storeImagePart(imageData, image, startPoint,widthOfTwoBands, this->bandIdentificationCount);
		}
		parameter++;
	}

	if (dnaBandWidth < 30 && widthOfTwoBands < 40) this->bandIdentificationCount;

	else this->bandIdentificationCount++;

	if (parameter > 0) startPoint = startPoint + widthOfTwoBands;

	else startPoint = startPoint + dnaBandWidth + widthOfTwoBands;

	int y = 0;
	parameter = 0;

	if (dnaBandWidth >= 0 && widthOfTwoBands > 0 && bandIdentificationCount <= 15) imageData = this->imageCroping(imageData,startPoint,y, image);

	return imageData;

}


vector<string> ImageSegmentation::split(string str, char delimiter) {
	vector<string> internal;
	std::stringstream ss(str); // Turn the string into a stream.
	string tok;

	while(getline(ss, tok, delimiter)) {
		internal.push_back(tok);
	}

	return internal;
}


vector<SegmentedImagePart> ImageSegmentation:: getSegmentedImageDetails(string imagePath,string dataList)
{
	GelUtils *gUtils=new GelUtils();
	vector<SegmentedImagePart> segParts;
	vector<string> sep = this->split(dataList, ',');

	for(int i=0 ;i<sep.size(); i++){ 

		vector<string> val= split(sep[i],':');
		SegmentedImagePart *segPart=new SegmentedImagePart();	  

		if(val.size()==2){
			segPart->setDeseaseType(val[0]);
			segPart->setPatientID(val[1]);		
		}	 
		else {
			segPart->setDeseaseType(val[0]);
			segPart->setPatientID("EMPTY");		
		}	 
		segParts.push_back(*segPart);
	}

	Mat image = imread(imagePath,CV_LOAD_IMAGE_UNCHANGED);
	image = gUtils->getRedChannelImage(image);

	if (image.empty())	
		std::cout << "cannot open the image";	

	segParts = this->getIntensityGraphs(segParts,image,"graphImage"); 
	return segParts;
}