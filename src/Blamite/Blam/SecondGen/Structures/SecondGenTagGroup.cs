﻿using Blamite.Serialization;

namespace Blamite.Blam.SecondGen.Structures
{
	public class SecondGenTagGroup : ITagGroup
	{
		public SecondGenTagGroup(StructureValueCollection values)
		{
			Load(values);
		}

		public int Magic { get; set; }
		public int ParentMagic { get; set; }
		public int GrandparentMagic { get; set; }
		public StringID Description { get; set; }

		private void Load(StructureValueCollection values)
		{
			Magic = (int) values.GetInteger("magic");
			ParentMagic = (int) values.GetInteger("parent magic");
			GrandparentMagic = (int) values.GetInteger("grandparent magic");
			// No description stringid :(
		}
	}
}