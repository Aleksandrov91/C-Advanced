namespace TeamBuilder.Models.Validation
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Text;

    internal class DateAttribute : ValidationAttribute
    {
        private DateTime startDate;

        public DateAttribute(DateTime startDate)
        {
            this.startDate = startDate;
        }

        public override bool IsValid(object value)
        {
            DateTime date = DateTime.ParseExact(value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (date.Date <= startDate.Date)
            {
                return false;
            }

            return true;
        }
    }
}
