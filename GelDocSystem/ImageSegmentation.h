#pragma once
#include "opencv\cv.h"
#include "opencv\highgui.h"
#include "SegmentedImagePart.h"
#include <numeric>
#include <functional>
#include <iostream>
#include <vector>
#include <string>
#include <sstream>
#include "DNABandPositionExtraction.h"

using namespace cv;
using namespace std;

#define GEL_DOC_EXPORTS

#ifdef GEL_DOC_EXPORTS
#define GEL_DOC_API __declspec(dllexport) 
#else
#define GEL_DOC_API __declspec(dllimport) 
#endif

class GEL_DOC_API ImageSegmentation
{
public:
	ImageSegmentation(void);
	~ImageSegmentation(void);

	vector<SegmentedImagePart> getIntensityGraphs(vector<SegmentedImagePart> imageData,Mat image,String name);
	vector<SegmentedImagePart> imageCroping(vector<SegmentedImagePart> imageData,int startPoint, int endPoint, Mat image);
	vector<string> split(string str, char delimiter);
	vector<SegmentedImagePart> getSegmentedImageDetails(string imagePath,string dataList);
	vector<SegmentedImagePart> storeImagePart(vector<SegmentedImagePart> Data, Mat image,int start, int dna, int num);
	char* ImageSegmentation ::columnDetailsAsString(vector<ColumnObject> columnDetails);
	char* extractImageData(char* imagePath,char* ImageData);

	int bandIdentificationCount;

private:
	DNABandPositionExtraction *dnaBandPositionExtraction;

};

