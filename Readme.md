<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128652177/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T158989)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF Data Grid - Exclude GridControl's Properties from Serialization

This example demonstrates how to exclude properties from serialization. To do this, handle the [DXSerializer.AllowProperty](http://docs.devexpress.com/WPF/DevExpress.Xpf.Core.Serialization.DXSerializer.AllowProperty) event for an object whose property should not be serialized. In the event handler, set the [AllowPropertyEventArgs.Allow](http://docs.devexpress.com/WPF/DevExpress.Xpf.Core.Serialization.AllowPropertyEventArgs.Allow) property to `False` to prohibit property serialization.

In this example, the **ID** column's [Width](http://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.BaseColumn.Width) property is excluded. Note that since [GridColumn](http://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridColumn) is not a [UIElement](https://docs.microsoft.com/en-us/dotnet/api/system.windows.uielement) descendant, it is necessary to use the [GridColumn.AddHandler](https://docs.microsoft.com/en-us/dotnet/api/system.windows.contentelement.addhandler) method instead of [DXSerializer.AddAllowPropertyHandler](http://docs.devexpress.com/WPF/DevExpress.Xpf.Core.Serialization.DXSerializer.AddAllowPropertyHandler(System.Windows.DependencyObject-DevExpress.Xpf.Core.Serialization.AllowPropertyEventHandler)) to subscribe to the event.

![image](https://user-images.githubusercontent.com/65009440/172786765-c651fed7-45ad-4db9-80a4-f90db99b7b88.png)

<!-- default file list -->

## Files to look at

* [MainWindow.xaml](./CS/WpfApplication58/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication58/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication58/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication58/MainWindow.xaml.vb))

<!-- default file list end -->

## Documentation

* [DXSerializer Events - Advanced Scenarios](http://docs.devexpress.com/WPF/7410/common-concepts/saving-and-restoring-layouts/advanced-scenarios)
* [WPF Data Grid - Save and Restore Layout](http://docs.devexpress.com/WPF/6797/controls-and-libraries/data-grid/miscellaneous/save-and-restore-layout)

## More Examples

* [WPF Data Grid - Save Layout and Restore It from a Memory Stream](https://github.com/DevExpress-Examples/how-to-save-grid-layout-to-and-restore-it-from-a-memory-stream-e1655)
* [WPF MVVM Framework - Serialize/Deserialize a View's Size and State with LayoutSerializationService and CurrentWindowSerializationBehavior](https://github.com/DevExpress-Examples/wpf-mvvm-behaviors-currentwindowserializationbehavior)
