﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IGI.Entities
{
	public class PCPart
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public string Image { get; set; }
		public int CategoryId { get; set; }

	}
}
