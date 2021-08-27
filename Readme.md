<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128598311/2019.2)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4247)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form2.cs](./CS/Reporting_how-to-add-a-pre-created-parameter-instance-to-the-field-list-and-keep-the-e4247/Form2.cs) (VB: [Form2.vb](./VB/Reporting_how-to-add-a-pre-created-parameter-instance-to-the-field-list-and-keep-the-e4247/Form2.vb))
<!-- default file list end -->
# How to add a pre-created parameter instance to the Field List and keep the parameter's name

<p>This example demonstrates how to programmatically add a report parameter to the report that is being opened in the End\-User report designer. To display a report in the Field List, it is not sufficient to add it to the XtraReport.Parameters collection. You will also need to use the DesignToolHelper.AddToContainer method and specify the target XRDesignPanel.</p>

<br/>


