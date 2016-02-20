#pragma once
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

class GelUtils
{
public:
	GelUtils(void);
	~GelUtils(void);	
	
	Mat getRedChannelImage(Mat image);
	vector<long> nonMaximaSupression(vector<long> rowValues);
	vector<std::pair<int, int>> sortBykey(vector<std::pair<int, int>> topElements);
	float getMeanWithinRange(int start,int end,vector<long> rowValues);
	float getStandardDeviationWithinRange(vector<long> rowValues,int start,int end);
	map<int, int> getPeakIntensityBandsBetweenTwoPositions(vector<long> rowValues,int firstBandPosition,int secondBandPosition);
	vector<std::pair<int, int>> findTopNumberOfIntensityBands(std::map<int, int> bandValues,int topCount);
	vector<std::pair<int, int>> mergeTwoPairVectors(vector<std::pair<int, int>> firstVector,vector<std::pair<int, int>> secondVector);
	vector<long> removeAllNonPeakPositionsWithinImage(vector<std::pair<int, int>> allPeakPositions,vector<long> rowValues);
	void drawHistogramWithAttachedToImage(Mat image,String name,vector<long> rowValues,double maxIntensityCount);
	vector<long> removeIntensitiesLowerThanMean(int start,int end,vector<long> rowValues,float mean);

};

