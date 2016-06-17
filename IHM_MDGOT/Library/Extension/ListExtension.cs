﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace IHM_MDGOT.Extension {
	public static class ListExtension {
		public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> enumerable) {
			var col = new ObservableCollection<T>();
			foreach (var cur in enumerable) {
				col.Add(cur);
			}
			return col;
		}
	}
}
