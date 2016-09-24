﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ListApp {
	class ListItemToValueConverter : IValueConverter {
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
			ListItem li = value as ListItem;
			ItemTemplateItem iti = parameter as ItemTemplateItem;
			return li.FindField(iti.Name).Value;
		}
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
			throw new NotImplementedException();
		}
	}
	class ListItemToEnumConverter : IValueConverter {
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
			ListItem li = value as ListItem;
			ItemTemplateItem iti = parameter as ItemTemplateItem;
			EnumField ef = li.FindField(iti.Name) as EnumField;
			return ef.GetSelectedValue(iti.Metadata);
		}
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
			throw new NotImplementedException();
		}
	}
	class ListItemToNumberConverter : IValueConverter {
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
			ListItem li = value as ListItem;
			ItemTemplateItem iti = parameter as ItemTemplateItem;
			return string.Format("{0:n0}", (int)li.FindField(iti.Name).Value);
		}
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
			throw new NotImplementedException();
		}
	}
	class ListItemToDecimalConverter : IValueConverter {
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
			ListItem li = value as ListItem;
			ItemTemplateItem iti = parameter as ItemTemplateItem;
			return ((float)li.FindField(iti.Name).Value).ToString();
		}
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
			throw new NotImplementedException();
		}
	}
	class ListItemToImageConverter : IValueConverter {
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
			ListItem li = value as ListItem;
			ItemTemplateItem iti = parameter as ItemTemplateItem;
			ImageField imgF = li.FindField(iti.Name) as ImageField;
			return imgF.GetBitmapImage();
		}
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
			throw new NotImplementedException();
		}
	}
}
