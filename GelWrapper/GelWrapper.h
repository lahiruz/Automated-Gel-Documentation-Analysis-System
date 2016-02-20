// GelWrapper.h

#pragma once
#include "ImageSegmentation.h"
#include "DNABandPositionExtraction.h"

using namespace System;

namespace GelWrapper {

	public ref class GelDocWrapper
	{
	public:
		GelDocWrapper();
		System::String^ wrapExecute(System::String^ imagePath,System::String^ imageData);

	private:
		ImageSegmentation *imageSegmentation;
	};
}
