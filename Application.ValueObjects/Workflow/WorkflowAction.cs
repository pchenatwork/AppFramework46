using Framework.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Application.ValueObjects.Workflow
{
    [Serializable]
    public class WorkflowAction : ValueObjectBase
    {
        #region	Private Members
        // *************************************************************************
        //				 Private Members
        // *************************************************************************
        private int _workflowNodeId;
        private string _name = string.Empty;
        private string _description = string.Empty;
        private int _actionTypeEnum;
        private string _actionType;
        private string _functionName = string.Empty;
        private string _functionParams = string.Empty;
        private int _displayOrder;
        private int _status;
        #endregion Private Members

        #region	Properties
        [XmlAttribute()]
        public int WorkflowId { get => _workflowNodeId; set => _workflowNodeId = value; }
        [XmlAttribute()]
        public string Name { get; set; }
        [XmlAttribute()]
        public string Description { get; set; }
        [XmlAttribute()]
        public int ActionTypeEnum { get; set; }
        [XmlAttribute()]
        public string ActionType { get; set; }
        [XmlAttribute()]
        public string FunctionName { get; set; }
        [XmlAttribute()]
        public string FunctionParams { get; set; }
        [XmlAttribute()]
        public int DisplayOrder { get; set; }
        [XmlAttribute()]
        public int Status { get; set; }
        #endregion Properties

        #region Methods
        public override void CopyFrom(IValueObject source)
        {
            base.CopyFrom(source);
            WorkflowAction _ = (WorkflowAction)source;
            this.WorkflowId = _.WorkflowId;
            this.Name = _.Name;
            this.Description = _.Description;
            this.ActionType = _.ActionType;
            this.ActionTypeEnum = _.ActionTypeEnum;
            this.FunctionName = _.FunctionName;
            this.FunctionParams = _.FunctionParams;
            this.Status = _.Status;
        }
        #endregion Methods
    }
}
