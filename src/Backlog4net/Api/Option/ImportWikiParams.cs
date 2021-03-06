﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Backlog4net.Api.Option
{
    public class ImportWikiParams : CreateWikiParams
    {
        public ImportWikiParams(long projectId, string name, string content)
            : base(projectId, name, content)
        {
        }

        public long CreatedUserId { set => AddNewParamValue(value); }

        public DateTime Created { set => AddNewParamValue(ToDateTimeString(value)); }

        public long UpdatedUserId { set => AddNewParamValue(value); }

        public DateTime Updated { set => AddNewParamValue(ToDateTimeString(value)); }
    }
}
