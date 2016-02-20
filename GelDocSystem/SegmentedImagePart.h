#pragma once
#include "opencv\cv.h"
#include "opencv\highgui.h"
#include <numeric>
#include <functional>
#include <iostream>
#include <vector>
#include <string>
#include <sstream>

using namespace cv;
using namespace std;

class SegmentedImagePart
{
public:
	SegmentedImagePart(void);
	~SegmentedImagePart(void);

	void setPatientID(string p_id){
		patientID=p_id;
	}

	string getPatientID(){
		return patientID;
	}

	void setDeseaseType(string dType){
		deseaseType=dType;
	}

	string getDeseaseType(){
		return deseaseType;
	}

	void setImagePart(Mat image){
		imagePart=image;
	}

	Mat getImagePart(){
		return imagePart;
	}


private:
	string patientID;
	string deseaseType;
	Mat imagePart;
};

