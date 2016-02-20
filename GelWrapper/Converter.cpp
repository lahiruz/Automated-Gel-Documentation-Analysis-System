#include "stdafx.h"
#include "Converter.h"
#include "opencv\cv.h"

using namespace System;
using namespace cv;

namespace GelWrapper {

Converter::Converter(void)
{
}

char* Converter::stringConvertionToChar(System::String^ str)
{
	IntPtr ptr = Marshal::StringToHGlobalAnsi(str);
	return static_cast<char*>(ptr.ToPointer());
}

Mat Converter::BitMapToMat(System::Drawing::Bitmap^ bitmap)
{
	//BitmapData::Stride similar to Mat::stepWidth
	System::Drawing::Imaging::BitmapData^ bmData = bitmap->LockBits(System::Drawing::Rectangle(0, 0, bitmap->Width, bitmap->Height), System::Drawing::Imaging::ImageLockMode::ReadWrite, bitmap->PixelFormat);
	Mat mat = Mat(cv::Size(bitmap->Width, bitmap->Height), CV_8UC3, bmData->Scan0.ToPointer(), std::abs(bmData->Stride));
	bitmap->UnlockBits(bmData);
	return mat;
}

System::String^ Converter::charConvertionToString(char* charList){

	System::String^ cli_str=gcnew System::String(charList);   
	return cli_str;
}

}