﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiNET.Utils;
using MiNET.Worlds;

namespace MiNET.Items
{
	class RawChicken : Item
	{
		internal RawChicken(short metadata) : base(365, metadata)
		{
		}

		public override Item GetSmelt()
		{
			return ItemFactory.GetItem(366);
		}
	}
}
