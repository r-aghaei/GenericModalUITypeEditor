# Generic Modal UITypeEditor
This example is insprired by a question in stackoverflow which asks [How to create custom generic PropertyGrid editor item which opens a form?](https://stackoverflow.com/q/46994063/3110834). The question abstraction is here:

Suppose we have a `MyBaseForm<T>` having a `SomeProperty` property and also we created a derived `DerivedForm : MyBaseForm<SampleModel>`. Now, the question is how can we have a Generic UI Type Editor `MyUITypeEditor<T>` which be used for editing `SomeProperty` of `DerivedForm` and shows a list of properties of `T`?

## Solution

To know how the solution works, you need to know when calling `EditValue` method of the `UITypeEditor`, the `context` parameter is of type `System.Windows.Forms.PropertyGridInternal.PropertyDescriptorGridEntry` which has a `Component` property which its value is the instance of the form which you are editing, so we know the type of the form and therefore we know the generic parameter type and therefore we can create our generic editor form.

Here are elements of the example:

- `MyBaseForm<T>`: The base form having a `SomeProperty` property. 
- `DerivedForm: MyBaseForm<SampleModel>` :  The derived form which we are going to edit its `SomeProperty` using our suctom editor.
- `SampleModel`: The mdoel which we are going to use as generic parameter.
- `MyEditorForm`: The generic editor form which will show a combo box containing propeties of the generic parameter.
- `MyUITypeEditor`: Our custom tricky UI Type Editor.

The example is ready to buidl. After you built the application, if you open `MyDerivedForm` and browse `SomeProperty` you will see the ditor form showing properties of generic type in combo box.

![GenericModalUITypeEditorSample](https://github.com/r-aghaei/GenericModalUITypeEditorSample/blob/master/images/editor.png)

The solution is valid for run-time as well.

![GenericModalUITypeEditorSample-execution](https://github.com/r-aghaei/GenericModalUITypeEditorSample/blob/master/images/execution.png)
