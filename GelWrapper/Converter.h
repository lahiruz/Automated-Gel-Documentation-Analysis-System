#pragma once
#include "opencv\cv.h"

using namespace std;
using namespace System;
using namespace System::Runtime::InteropServices;
using namespace cv;

namespace GelWrapper {

ref class Converter
{
public:
	Converter(void);
	char* stringConvertionToChar(System::String^ str);
	Mat BitMapToMat(System::Drawing::Bitmap^ bitmap);
	System::String^ charConvertionToString(char* charList);
};

}