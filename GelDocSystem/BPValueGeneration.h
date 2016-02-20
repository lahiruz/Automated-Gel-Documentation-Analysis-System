#pragma once
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

class BPValueGeneration
{
public:
	BPValueGeneration(void);
	~BPValueGeneration(void);

	ColumnObject calculateLadderBPValues(ColumnObject ladderObject);
	ColumnObject calculateSampleBPValues(bool isLadder50BP, vector<float> calculatedLadderBPPositions, ColumnObject foundedSampleBandPositions,std::ofstream &sampleDataFile);
	std::vector<float> calculateRelatedLadderPositions(ColumnObject ladderObj,vector<int> referenceLadderValuesInBP,int distance,bool is50BP);	

};

