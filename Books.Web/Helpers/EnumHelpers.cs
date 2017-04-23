using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Books.Web.Helpers
{
	public static class EnumHelpers
	{
		public static string GetDisplayName(this Type enumType, int? selectedValue)
		{
			var name = Enum.GetName(enumType, selectedValue);
			var displayName = enumType.GetField(name)
				.GetCustomAttributes(inherit: false)
				.OfType<DisplayAttribute>()
				.FirstOrDefault()?.Name;

			return displayName ?? name;
		}
	}
}