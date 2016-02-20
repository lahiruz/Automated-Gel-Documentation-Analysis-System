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

using namespace cv;
using namespace std;

GelUtils::GelUtils(void)
{
}

GelUtils::~GelUtils(void)
{
}

Mat GelUtils::getRedChannelImage(Mat image){

	Mat redChannelImage(image.size(),CV_8UC1);

	//store red channal values
	for(int i=0;i<image.cols;i++)
	{
		for(int j=0;j<image.rows;j++)
		{
			//3rd channel of a pixel represent the red channel 
			int pxVal=image.at<Vec3b>(j,i)[2];			
			redChannelImage.at<uchar>(j,i)=(uchar)pxVal;

		}
	}

	//namedWindow("Red_Channel");	
	//imshow("Red_Channel",redChannelImage);
	//imwrite("E:\\Images\\image_pro_pics\\4yr project pics\\Final project Images\\Image parts\\parts\\Red_Channel.jpg",redChannelImage);
	imwrite("F:\\Images\\4 Year Project\\ProcessedImageData\\Red_Channel_Image.jpg",redChannelImage);
	

	return redChannelImage;

}

vector<long> GelUtils::nonMaximaSupression(vector<long> rowValues){
	for (int i = 1; i < rowValues.size()-1; i++) 
	{
		if(rowValues.at(i-1)<rowValues.at(i) && rowValues.at(i)>rowValues.at(i+1)){ // keep middle
			rowValues.at(i-1)=0;
			rowValues.at(i+1)=0;
		}else if(rowValues.at(i-1)<rowValues.at(i) && rowValues.at(i)<rowValues.at(i+1)){ // keep right
			rowValues.at(i-1)=0;
			rowValues.at(i)=0;
		}else if(rowValues.at(i-1)>rowValues.at(i) && rowValues.at(i)>rowValues.at(i+1)){ // keep left
			rowValues.at(i)=0;
			rowValues.at(i+1)=0;
		}else if(rowValues.at(i-1)==rowValues.at(i) && rowValues.at(i)>rowValues.at(i+1)){ // keep middle when left and middle equal
			//rowValues.at(i-1)=0;
			//rowValues.at(i+1)=0;
		}else if(rowValues.at(i-1)<rowValues.at(i) && rowValues.at(i)==rowValues.at(i+1)){ // keep middle when right and middle equal
			//rowValues.at(i-1)=0;
			//rowValues.at(i+1)=0;
		}else if(rowValues.at(i-1)==rowValues.at(i+1) && rowValues.at(i-1)>rowValues.at(i)){ // keep left when left and right equal
			//rowValues.at(i)=0;
			//rowValues.at(i+1)=0;
		}
	}

	return rowValues;
}

vector<std::pair<int, int>> GelUtils::sortBykey(vector<std::pair<int, int>> topElements){

	std::sort(topElements.begin(),topElements.end());

	topElements.erase(std::remove_if(topElements.begin(), topElements.end(), 
		[](pair<int, int> p) { return p.first == 0; }), topElements.end());

	return topElements;
}

float GelUtils::getStandardDeviationWithinRange(vector<long> rowValues,int start,int end)
{
	int n=end-start;
	float sum_deviation=0.0;	
	float mean=this->getMeanWithinRange(start,end,rowValues);

	for(int i=start; i<=end;++i)
		sum_deviation+=(rowValues[i]-mean)*(rowValues[i]-mean);
	return sqrt(sum_deviation/n);           
}

map<int, int> GelUtils::getPeakIntensityBandsBetweenTwoPositions(vector<long> rowValues,int firstBandPosition,int secondBandPosition){

	std::map<int, int> bandPositionsBetweenSecondAndThird; 
	int peakIndex=firstBandPosition;
	int peak=rowValues.at(firstBandPosition);
	bool isPeak=false;	

	for(int i=firstBandPosition+1;i<=secondBandPosition;i++){		

		if(rowValues.at(i)!=0){

			if((rowValues.at(i)-peak) > 0) isPeak=false;			

			else if((rowValues.at(i)-peak) < 0 && !isPeak){ 			
				isPeak=true;	
				rowValues.at(peakIndex)=peak;		

				if(peakIndex != firstBandPosition){
					//std::cout << peakIndex << "=>" << peak <<"\n";
					bandPositionsBetweenSecondAndThird[peakIndex]=peak;
				}
			}

			peakIndex = i;
			peak = rowValues.at(i);		
			rowValues.at(i)=0;		
		}
	}

	return bandPositionsBetweenSecondAndThird;

}

vector<std::pair<int, int>> GelUtils:: findTopNumberOfIntensityBands(std::map<int, int> bandValues,int topCount){
	std::vector<std::pair<int, int>> top_elements(topCount);
	std::partial_sort_copy(bandValues.begin(),
		bandValues.end(),
		top_elements.begin(),
		top_elements.end(),
		[](std::pair<const int , int> const& l,
		std::pair<const int , int> const& r)
	{
		return l.second > r.second;
	});

	return top_elements;

}

vector<std::pair<int, int>> GelUtils::mergeTwoPairVectors(vector<std::pair<int, int>> firstVector,vector<std::pair<int, int>> secondVector){

	std::vector<std::pair<int, int>> allPeakPositions;

	allPeakPositions.reserve( firstVector.size() + secondVector.size() ); // preallocate memory
	allPeakPositions.insert( allPeakPositions.end(), firstVector.begin(), firstVector.end() );
	allPeakPositions.insert( allPeakPositions.end(), secondVector.begin(), secondVector.end() );	
	return allPeakPositions;
}

vector<long> GelUtils::removeAllNonPeakPositionsWithinImage (vector<std::pair<int, int>> allPeakPositions,vector<long> rowValues){

	int start=0;
	int count=0;

	for(auto const& p: allPeakPositions){

		for(int i=start;i<rowValues.size();i++){

			if(p.first!=i) 
				rowValues.at(i)=0;
			else{
				count++;
				start=i+1;
				break;
			}
		}
	}
	//assign zero for all pixel values which after the third top intensity band position
	if(count==allPeakPositions.size()){		
		for(int i=start;i<rowValues.size();i++){
			rowValues.at(i)=0;
		}
	}
	return rowValues;
}

void GelUtils::drawHistogramWithAttachedToImage(Mat image,String name,vector<long> rowValues,double maxIntensityCount){

	Mat histImage(image.rows, image.cols + 300, CV_8UC3, Scalar(0));

	//draw horizontal histogram
	for (int i = 0; i < rowValues.size(); i++) 
	{
		line(histImage, Point(cvRound((rowValues.at(i) / maxIntensityCount) * 300), i),
			Point(0,i), Scalar(0, 255, 0), 1, 8, 0);
	}

	cvtColor(image, image, CV_GRAY2BGR);
	cv::Rect roi(cv::Point(300, 0), image.size());
	image.copyTo(histImage(roi));

	//namedWindow(name);
	//imshow(name, histImage);	
	
	//imwrite("E:\\Images\\image_pro_pics\\4yr project pics\\Final project Images\\Image parts\\ladders\\tempLadders\\" + name + ".jpg",histImage);	
	//imwrite("E:\\Images\\image_pro_pics\\4yr project pics\\Final project Images\\Image parts\\parts\\"+name+".jpg",histImage);	
	//imwrite("E:\\Images\\image_pro_pics\\4yr project pics\\Final project Images\\Image parts\\newSegmentedParts 2015,12,4\\NO DNA 1\\"+name+".jpg",histImage);	
	
	imwrite("F:\\Images\\4 Year Project\\ProcessedImageData\\Band_Extracted_Image_Parts\\"+name+".jpg",histImage);
	

}

float GelUtils::getMeanWithinRange(int start,int end,vector<long> rowValues)
{
	int n=end-start;
	float mean=0.0, sum_deviation=0.0;
	int i;
	for(i=start; i<=end;++i)
	{
		mean+=rowValues.at(i);
	}
	mean=mean/n;
	
	return mean;
}

vector<long> GelUtils::removeIntensitiesLowerThanMean (int start,int end,vector<long> rowValues,float mean){

	for(int i=start;i<=end;i++){
		if(rowValues.at(i)<mean) rowValues.at(i)=0;		
	}	
	return rowValues;
}


