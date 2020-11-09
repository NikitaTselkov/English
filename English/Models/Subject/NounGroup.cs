using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace English.Models.Subject
{
    /// <summary>
    /// Группа существительных.
    /// </summary>
    [DataContract]
    [KnownType(typeof(NounGroup))]
    public class NounGroup : AbstractSubject
    {
        /// <summary>
        /// Группа существительных.
        /// </summary>
        [DataMember]
        public AbstractSubject[] NounsGroup { get; private set; }

        /// <summary>
        /// Установка значений.
        /// </summary>
        /// <param name="nounsGroup"> Группа существительных. </param>
        public NounGroup(AbstractSubject[] nounsGroup)
        {
            NounsGroup = nounsGroup;
        }

        public NounGroup() { }
    }
}
