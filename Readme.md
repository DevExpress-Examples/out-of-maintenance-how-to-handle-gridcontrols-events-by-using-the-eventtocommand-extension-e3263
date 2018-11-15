<!-- default file list -->
*Files to look at*:

* [MainViewModel.cs](./CS/EventToCommandExample/ViewModels/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/EventToCommandExample/ViewModels/MainViewModel.vb))
* **[MainView.xaml](./CS/EventToCommandExample/Views/MainView.xaml) (VB: [MainView.xaml](./VB/EventToCommandExample/Views/MainView.xaml))**
<!-- default file list end -->
# How to handle GridControl's events by using the EventToCommand extension


<p><a href="https://documentation.devexpress.com/#WPF/CustomDocument15112">MVVM Framework</a> provides the <a href="https://documentation.devexpress.com/#WPF/clsDevExpressMvvmUIEventToCommandtopic">EventToCommand</a> class that allows delegating event processing logic to the ViewModel level. This example illustrates how to use this functionality to process DXGrid events.</p>
<p>The EventToCommand class provides the <a href="https://documentation.devexpress.com/#WPF/DevExpressMvvmUIEventToCommand_PassEventArgsToCommandtopic">PassEventArgsToCommand</a> option that allows passing the corresponding EventArgs as a command parameter. If necessary, you can extract the required information from event arguments and then pass this information as a command parameter. To do this, use the <a href="https://documentation.devexpress.com/#WPF/DevExpressMvvmUIEventToCommand_EventArgsConvertertopic">EventArgsConverter</a>.</p>

<br/>


