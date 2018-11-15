<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication58/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/WpfApplication58/MainWindow.xaml.vb))
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


