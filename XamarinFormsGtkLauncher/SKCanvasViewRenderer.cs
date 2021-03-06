﻿using XamarinFormsGtkLauncher.SkiaRenderer;
using Xamarin.Forms.Platform.GTK;
using SKFormsView = SkiaSharp.Views.Forms.SKCanvasView;
using SKNativeView = SkiaSharp.Views.Gtk.SKWidget;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(SKFormsView), typeof(SKCanvasViewRenderer))]
namespace XamarinFormsGtkLauncher.SkiaRenderer
{
    public class SKCanvasViewRenderer : SKCanvasViewRendererBase<SKFormsView, SKNativeView>
    {
    }
}