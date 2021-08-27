<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/272662402/20.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T899944)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/RealTimeChartUpdates/Form1.cs) (VB: [Form1.vb](./VB/RealTimeChartUpdates/Form1.vb))
<!-- default file list end -->

# How to: Create a Real-Time Chart and Collect Data in a Separate Thread

The chart processes points that are within its viewport. In this example, points that are beyond the viewport are removed from the data source - starting from the beginning of the collection. The example uses a separate thread to accumulate data points. A new batch of data points is generated every 15 milliseconds. The chart fetches a new portion of points to visualize at a rate of ten times per second.
