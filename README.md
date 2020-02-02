# Telerik UWP Projects
A set of custom controls and utilities using Telerik's UI for UWP (I will add more as I build them)
*Note: For my non-Telerik UWP helpers, go here https://github.com/LanceMcCarthy/UwpProjects*

##Contents
* DateRangePicker (selects a date range with start/end overlap protection, Binding and Event support)


###DateRangePicker

![alt tag](https://i.gyazo.com/985e926ed201a7991aee4c4110bacbcc.gif)



**Properties and Events**
* StartDate (DateTime)
* EndDate (DateTime)
* DateRangeChanged (passed DateRangeChangedEventArgs)


**Databinding use example**

```
<pickers:DateRangePicker StartDate="{Binding MyStartDate, Mode=TwoWay}"
                                EndDate="{Binding MyEndDate, Mode=TwoWay}" />
```


**Event use example**


*XAML*

```
<pickers:DateRangePicker x:Name="MyDateRangePicker"
                                DateRangeValueChanged="MyDateRangePicker_OnDateRangeValueChanged" />
```


*Event Handler*

```
private void MyDateRangePicker_OnDateRangeValueChanged(object sender, DateRangeChangedEventArgs e)
{
      var startDate = e.StartDate;
      var endDate = e.EndDate;
}
```

* Updating to be included in the Arctic Code Vault
