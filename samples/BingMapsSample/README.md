Bing Maps support is commented out in the .NET Core Control project since it has dependency on [Bing Maps WPF Control](http://www.microsoft.com/downloads/details.aspx?familyid=1f735eac-d893-4814-84e8-20f00fa617ba)

Code for Bing Maps in the Control is located in [/Plot/BingMaps/BingMapsChart.cs](https://github.com/sukesh-ak/InteractiveDataDisplay.WPF/blob/core/src/Plots/BingMaps/BingMapsChart.cs) which is hidden inside 'if NETFRAMEWORK' thus disabled in the .NET Core version.

This needs to be addressed in case Bing Maps WPF Control version for .NET Core comes out in future.


Test the Unofficial .NET Core 3.1 Bing Maps WPF Control (reverse engineered) later -
[ViceCode.MapControl.WPF](https://github.com/vice-code/ViceCode.MapControl.WPF)