﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace RadialMenu.Controls
{
    /// <summary>
    /// Interaction logic for RadialMenuItem.xaml
    /// </summary>
    public class RadialMenuItem : Button
    {
        public static readonly DependencyProperty IndexProperty =
            DependencyProperty.Register("Index", typeof(int), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public int Index
        {
            get { return (int)GetValue(IndexProperty); }
            set { SetValue(IndexProperty, value); }
        }

        public static readonly DependencyProperty CountProperty =
            DependencyProperty.Register("Count", typeof(int), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(1, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public int Count
        {
            get { return (int)GetValue(CountProperty); }
            set { SetValue(CountProperty, value); }
        }

        public static readonly DependencyProperty CenterXProperty =
            DependencyProperty.Register("CenterX", typeof(double), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public double CenterX
        {
            get { return (double)GetValue(CenterXProperty); }
            set { SetValue(CenterXProperty, value); }
        }

        public static readonly DependencyProperty CenterYProperty =
            DependencyProperty.Register("CenterY", typeof(double), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public double CenterY
        {
            get { return (double)GetValue(CenterYProperty); }
            set { SetValue(CenterYProperty, value); }
        }

        public static readonly DependencyProperty OuterRadiusProperty =
            DependencyProperty.Register("OuterRadius", typeof(double), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public double OuterRadius
        {
            get { return (double)GetValue(OuterRadiusProperty); }
            set { SetValue(OuterRadiusProperty, value); }
        }

        public static readonly DependencyProperty InnerRadiusProperty =
            DependencyProperty.Register("InnerRadius", typeof(double), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public double InnerRadius
        {
            get { return (double)GetValue(InnerRadiusProperty); }
            set { SetValue(InnerRadiusProperty, value); }
        }

        public new static readonly DependencyProperty PaddingProperty =
            DependencyProperty.Register("Padding", typeof(double), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public new double Padding
        {
            get { return (double)GetValue(PaddingProperty); }
            set { SetValue(PaddingProperty, value); }
        }

        public new static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(Panel), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public new Panel Content
        {
            get { return (Panel)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        public static readonly DependencyProperty ContentRadiusProperty =
            DependencyProperty.Register("ContentRadius", typeof(double), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public double ContentRadius
        {
            get { return (double)GetValue(ContentRadiusProperty); }
            set { SetValue(ContentRadiusProperty, value); }
        }

        public static readonly DependencyProperty EdgeOuterRadiusProperty =
            DependencyProperty.Register("EdgeOuterRadius", typeof(double), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public double EdgeOuterRadius
        {
            get { return (double)GetValue(EdgeOuterRadiusProperty); }
            set { SetValue(EdgeOuterRadiusProperty, value); }
        }

        public static readonly DependencyProperty EdgeInnerRadiusProperty =
            DependencyProperty.Register("EdgeInnerRadius", typeof(double), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public double EdgeInnerRadius
        {
            get { return (double)GetValue(EdgeInnerRadiusProperty); }
            set { SetValue(EdgeInnerRadiusProperty, value); }
        }

        public static readonly DependencyProperty EdgePaddingProperty =
            DependencyProperty.Register("EdgePadding", typeof(double), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public double EdgePadding
        {
            get { return (double)GetValue(EdgePaddingProperty); }
            set { SetValue(EdgePaddingProperty, value); }
        }

        public static readonly DependencyProperty EdgeBackgroundProperty =
            DependencyProperty.Register("EdgeBackground", typeof(Brush), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public Brush EdgeBackground
        {
            get { return (Brush)GetValue(EdgeBackgroundProperty); }
            set { SetValue(EdgeBackgroundProperty, value); }
        }

        public static readonly DependencyProperty EdgeBorderThicknessProperty =
            DependencyProperty.Register("EdgeBorderThickness", typeof(double), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public double EdgeBorderThickness
        {
            get { return (double)GetValue(EdgeBorderThicknessProperty); }
            set { SetValue(EdgeBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty EdgeBorderBrushProperty =
            DependencyProperty.Register("EdgeBorderBrush", typeof(Brush), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public Brush EdgeBorderBrush
        {
            get { return (Brush)GetValue(EdgeBorderBrushProperty); }
            set { SetValue(EdgeBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ArrowBackgroundProperty =
            DependencyProperty.Register("ArrowBackground", typeof(Brush), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public Brush ArrowBackground
        {
            get { return (Brush)GetValue(ArrowBackgroundProperty); }
            set { SetValue(ArrowBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ArrowBorderThicknessProperty =
            DependencyProperty.Register("ArrowBorderThickness", typeof(double), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public double ArrowBorderThickness
        {
            get { return (double)GetValue(ArrowBorderThicknessProperty); }
            set { SetValue(ArrowBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ArrowBorderBrushProperty =
            DependencyProperty.Register("ArrowBorderBrush", typeof(Brush), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public Brush ArrowBorderBrush
        {
            get { return (Brush)GetValue(ArrowBorderBrushProperty); }
            set { SetValue(ArrowBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ArrowWidthProperty =
            DependencyProperty.Register("ArrowWidth", typeof(double), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public double ArrowWidth
        {
            get { return (double)GetValue(ArrowWidthProperty); }
            set { SetValue(ArrowWidthProperty, value); }
        }

        public static readonly DependencyProperty ArrowHeightProperty =
            DependencyProperty.Register("ArrowHeight", typeof(double), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public double ArrowHeight
        {
            get { return (double)GetValue(ArrowHeightProperty); }
            set { SetValue(ArrowHeightProperty, value); }
        }

        public static readonly DependencyProperty ArrowRadiusProperty =
            DependencyProperty.Register("ArrowRadius", typeof(double), typeof(RadialMenuItem),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public double ArrowRadius
        {
            get { return (double)GetValue(ArrowRadiusProperty); }
            set { SetValue(ArrowRadiusProperty, value); }
        }

        static RadialMenuItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadialMenuItem), new FrameworkPropertyMetadata(typeof(RadialMenuItem)));
        }
    }
}
