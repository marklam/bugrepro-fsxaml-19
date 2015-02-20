module main

open System
open System.Windows
open System.Windows.Controls
open System.Windows.Markup

open FsXaml

type App = XAML<"App.xaml">
type MainWindow = XAML<"MainWindow.xaml">

let app = App().Root
let mainWindow = MainWindow().Root

[<STAThread>]
[<EntryPoint>]
let main(_) = 
    app.Run(mainWindow)
