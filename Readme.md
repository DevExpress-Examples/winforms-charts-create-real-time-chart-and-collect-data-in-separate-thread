<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/272662402/20.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T899944)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Chart for WinForms - Create a Real-Time Chart and Collect Data in a Separate Thread

The chart processes points that are within its viewport. In this example, points that are beyond the viewport are removed from the data source - starting from the beginning of the collection. The example uses a separate thread to accumulate data points. A new batch of data points is generated every 15 milliseconds. The chart fetches a new portion of points to visualize at a rate of ten times per second.

## Files to Review

* [Form1.cs](./CS/RealTimeChartUpdates/Form1.cs) (VB: [Form1.vb](./VB/RealTimeChartUpdates/Form1.vb))

## Documentation

* [Create a Real-Time Chart](https://docs.devexpress.com/WindowsForms/401813/controls-and-libraries/chart-control/examples/creating-charts/providing-data/how-to-create-a-real-time-chart?v=23.1&p=netframework)

## More Examples

* [How to: Create a Real-Time Chart](https://github.com/DevExpress-Examples/xtracharts-how-to-create-a-real-time-chart)
* [Chart for WinForms - Use the SwiftPlot Diagram to Create a Real-Time Chart](https://github.com/DevExpress-Examples/winforms-charts-configure-swift-plot-chart)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-charts-create-real-time-chart-and-collect-data-in-separate-thread&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-charts-create-real-time-chart-and-collect-data-in-separate-thread&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
