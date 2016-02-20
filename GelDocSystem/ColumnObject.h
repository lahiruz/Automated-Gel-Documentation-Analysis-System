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

class ColumnObject
{
public:
	ColumnObject(void);
	~ColumnObject(void);

	void setPatientId(string p_Id){
		patientId=p_Id;
	}
	void setColumnType(string c_Type){
		columnType=c_Type;
	}	
	void setBandPositions(vector<float> bandValues){
		bandPositions=bandValues;
	}	
	string getPatientId(){
		return patientId;
	}
	string getColumnType(){
		return columnType;
	}	
	vector<float> getBandPositions(){
		return bandPositions;
	}	

private:
	string patientId;
	string columnType;
	vector<float> bandPositions;
};

