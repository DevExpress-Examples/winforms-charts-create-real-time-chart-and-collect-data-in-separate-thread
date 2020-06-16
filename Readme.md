<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/RealTimeChartUpdates/Form1.cs) (VB: [Form1.vb](./VB/RealTimeChartUpdates/Form1.vb))
<!-- default file list end -->

# How to: Create a Real-Time Chart and Collect Data in a Separate Thread

The chart processes points that are within its viewport. In this example, points that are beyond the viewport are removed from the data source - starting from the beginning of the collection. The example uses a separate thread to accumulate data points. A new batch of data points is generated every 15 milliseconds. The chart fetches a new portion of points to visualize at a rate of ten times per second.