using System.ComponentModel.Composition;
using Microsoft.Isam.Esent.Interop;
using Raven.Database;
using Raven.Database.Impl;

namespace Raven.Storage.Esent.SchemaUpdates
{
	[InheritedExport]
	public interface ISchemaUpdate
	{
		string FromSchemaVersion { get;  }
	    void Init(IUuidGenerator generator);
		void Update(Session session, JET_DBID dbid);
	}
}
