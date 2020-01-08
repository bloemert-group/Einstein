﻿using Einstein.DataAccessLayer.Core;

namespace Einstein.DataAccessLayer.Entities
{
  public class Sector : BaseEntity
	{
		public virtual int Seqno { get; set; }

		public virtual string Name { get; set; }

		public virtual string Description { get; set; }

	}
}