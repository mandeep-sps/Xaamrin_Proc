//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("MyTestApp.Views.CatView.xaml", "Views/CatView.xaml", typeof(global::MyTestApp.Views.CatView))]

namespace MyTestApp.Views {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views/CatView.xaml")]
    public partial class CatView : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::MyTestApp.Models.CatModel vm;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(CatView));
            vm = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::MyTestApp.Models.CatModel>(this, "vm");
        }
    }
}
