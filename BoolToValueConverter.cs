using System.Globalization;

namespace MauiApp1
{
    public class BoolToValueConverter : BindableObject, IValueConverter
    {
        public static readonly BindableProperty TrueValueProperty = BindableProperty.Create(propertyName: nameof(TrueValue), returnType: typeof(object),
            declaringType: typeof(BoolToValueConverter));

        public static readonly BindableProperty FalseValueProperty = BindableProperty.Create(propertyName: nameof(FalseValue), returnType: typeof(object),
            declaringType: typeof(BoolToValueConverter));

        /// <summary>Value to return when the bool to convert is <c>true</c>.</summary>
        public object? TrueValue
        {
            get => GetValue(TrueValueProperty);
            set => SetValue(TrueValueProperty, value);
        }

        /// <summary>Value to return when the bool to convert is <c>false</c>.</summary>
        public object? FalseValue
        {
            get => GetValue(FalseValueProperty);
            set => SetValue(FalseValueProperty, value);
        }

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            bool result = (value is bool b && b);
            return result ? TrueValue : FalseValue;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
