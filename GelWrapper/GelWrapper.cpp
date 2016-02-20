// This is the main DLL file.

#include "stdafx.h"
#include "GelWrapper.h"
#include "Converter.h"
#include "SegmentedImagePart.h"
#include "ColumnObject.h"

namespace GelWrapper{

	GelDocWrapper::GelDocWrapper()
	{
		imageSegmentation=new ImageSegmentation();
	}

	System::String^ GelDocWrapper::wrapExecute(System::String^ imagePath,System::String^ imageData){	

		Converter ^convert=gcnew Converter();

		char* gelImagePath=convert->stringConvertionToChar(imagePath);
		char* gelImageUserEnteredData=convert->stringConvertionToChar(imageData);
		
		char* gelImageDataSet = this->imageSegmentation->extractImageData(gelImagePath,gelImageUserEnteredData);		
				
		System::String^ convetedGelImageDataString =convert->charConvertionToString(gelImageDataSet);

		return convetedGelImageDataString;

	}
}
