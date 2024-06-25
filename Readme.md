<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128652177/14.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T158989)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication58/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication58/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication58/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication58/MainWindow.xaml.vb))
<!-- default file list end -->
# How to prevent certain GridControl's properties from being serialized


<p>This example demonstrates how to exclude specific properties from serialization. To accomplish this task, handle the DXSerializer.AllowProperty event for an object whose property shouldn't be serialized. In this event handler, set AllowPropertyEventArgs.Allow to 'False' to prohibit property serialization. <br />In this particular example, the GridColumn.ActualWidth property has been excluded. Please note that since GridColumn is not a UIElement descendant, it's necessary to use the GridColumn.AddHandler method instead of DXSerializer.AddAllowPropertyHandler to subscribe to the event.<br />If it's necessary to handle this event for all columns in GridControl, you can create a GridControl descendant and override the OnDeserializeAllowProperty method:</p>
<br />


```cs
    public class GridControlEx : GridControl
    {
        protected override bool OnDeserializeAllowProperty(AllowPropertyEventArgs e)
        {
            if (e.DependencyProperty == GridColumn.ActualWidthProperty)
                return false;
            return base.OnDeserializeAllowProperty(e);
        }
    }
```



<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-prevent-certain-gridcontrols-properties-from-being-serialized-t158989&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-prevent-certain-gridcontrols-properties-from-being-serialized-t158989&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
