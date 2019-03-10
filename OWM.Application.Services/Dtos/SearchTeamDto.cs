﻿using System;
using OWM.Application.Services.Enums;
using OWM.Domain.Entities.Enums;

namespace OWM.Application.Services.Dtos
{
    public class SearchTeamDto
    {
        public string SearchExpression { get; set; }
        public int MilesOrder { get; set; }
        public int MembersOrder { get; set; }
        public EnumOrderBy MilesOrderBy => (EnumOrderBy) MilesOrder;
        public EnumOrderBy MemberOrderBy => (EnumOrderBy)MembersOrder;
        public AgeRange AgeRange { get; set; }
        public int Occupation { get; set; }
    }
}