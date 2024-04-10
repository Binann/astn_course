using astn_course.Model;

namespace astn_course.Service
{
	public class ModuleService
	{
		public static List<StaticModel> ListGender()
		{
			List<StaticModel> list = new()
			{
				new StaticModel
				{
					id = 1,
					name = "Male",
				},
				new StaticModel
				{
					id = 2,
					name = "Female",
				},
				new StaticModel
				{
					id = 3,
					name = "Other",
				},
			};
			return list;
		}

		public static List<StaticModel> ListLevel() 
		{
			List<StaticModel> list = new()
			{
				new StaticModel
				{
					id = 1,
					name = "Beginners",
				},
				new StaticModel
				{
					id = 2,
					name = "Advance",
				},
				new StaticModel
				{
					id = 3,
					name = "Intermediate",
				},
			};
			return list;
		}
	}
}
