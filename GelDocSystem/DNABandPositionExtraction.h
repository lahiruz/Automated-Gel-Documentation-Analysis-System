#pragma once
#include "opencv\cv.h"
#include <vector>
#include "ColumnObject.h"
#include "SegmentedImagePart.h"

using namespace cv;
using namespace std;

#define GEL_DOC_EXPORTS

#ifdef GEL_DOC_EXPORTS
#define GEL_DOC_API __declspec(dllexport) 
#else
#define GEL_DOC_API __declspec(dllimport) 
#endif

class GEL_DOC_API DNABandPositionExtraction
{
public:
	DNABandPositionExtraction(void);
	~DNABandPositionExtraction(void);
	
	void getLadderBandPositions(String ladderType,Mat image,String name,vector<long> rowValues,int bandVal,std::ofstream &InputFile);
	vector<float> getSampleBandPositions(Mat image,String name,String deseaseType,vector<long> rowValues,int startingPoint,int endingPoint,std::ofstream &InputFile);
	vector<long> getIntensitiesAboveThreshold(Mat image,int thresholdIntensityValue,int startRow);	
	vector<float> getCalculatedLadderPositions(ColumnObject ladderObject);
	vector<std::pair<int, int>> removeBadDetectionsInTopIntensityPositions(vector<std::pair<int, int>> topElements,int bandDistanceThreshold);
	std::vector<std::pair<int, int>> getLevel2Peaks(vector<std::pair<int, int>> topElements,vector<long> rowValuesBeforeChange);		
	bool checkColumnContainAnyBands(Mat image,string name,vector<long> rowValues);	
	vector<ColumnObject> getFinallyExtractedImageColumnData(vector<SegmentedImagePart> segmentedImageParts);
	vector<ColumnObject> getColumnsToBeCalculatedBPValues(vector<SegmentedImagePart> neededSegmentedImageParts,std::ofstream &InputFile);
	bool DNABandPositionExtraction::isStartingPositionDetected(vector<long> rowValues,int requiredStartingPoint,int loopEndingPosition);
	vector<long> DNABandPositionExtraction::getIntermediateLadderProcessing(String ladderType,vector<long> rowValues,int startingPos, int endingPos,std::ofstream &InputFile);
	
	//store maximum intensity count
	double maxIntensityCount;

	//store the index of the 2nd highest band value in the ladder
	int secondTopBandIndex;

	//determine Ladder column is detected
	bool ladderDetected;

	//store 2nd highest band value in the ladder column
	bool secondTopBandDetected;

	//represent the position of 50BP value band
	int lastBPPositionInLadder;

	//check NO DNA column is ok
	bool isNoDNAColumnChecked;

	//check the column is a patient sample 
	bool isSampleColumn;

	//check positive controller is valid
	bool isPositiveControllerValid;

	//store the positions of calculated ladder bands
	vector<float> calculatedLadderBandPositions; 

	//keep row Values before change
	vector<long> rowValuesBeforeChange;

	bool trueDMD;
	bool trueHD;
	bool trueStroke;
	bool trueNegativeController;
	bool isLadder50BP;

	//Threshold Values
	int intensityThreshold;
	int approximatedBandDistanceThreshold;
	int numberOfAboveBands;
	float ratioOfLength;
	int columnValidityThreshold;
	float columnValidityRatio;
	float stokeBandLenthRatio;

};

