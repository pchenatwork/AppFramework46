using Framework.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Application.ValueObjects.Workflow
{
    public class WorkflowNode : ValueObjectBase
    {
        #region	Properties
        private int _workflowNodeId;

        [XmlAttribute()]
        public int WorkflowId { get => _workflowNodeId; set => _workflowNodeId = value; }
        [XmlAttribute()]
        public string Name { get; set; }
        [XmlAttribute()]
        public string Description { get; set; }
        [XmlAttribute()]
        public int NoteTypeEnum { get; set; }
        [XmlAttribute()]
        public string NoteType { get; set; }
        [XmlAttribute()]
        public int NodeIdFrom { get; set; }
        [XmlAttribute()]
        public int NodeIdTo { get; set; }
        [XmlAttribute()]
        public int TimeToSkip { get; set; }
        [XmlAttribute()]
        public string Value { get; set; }

        [XmlArray("ArrayOfWorkflowAction")]
        public ValueObjectCollection<WorkflowAction> WorkflowActions { get; set; }
        #endregion Properties

        #region Methods
        public override void CopyFrom(IValueObject source)
        {
            base.CopyFrom(source);
            WorkflowNode _ = (WorkflowNode)source;
            WorkflowId = _.WorkflowId;
            Name = _.Name;
            Description = _.Description;
            NoteType = _.NoteType;
            NoteTypeEnum = _.NoteTypeEnum;
            TimeToSkip = _.TimeToSkip;
            Value = _.Value;
        }
        #endregion Methods
    }
}
