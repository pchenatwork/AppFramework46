[WorkflowNode].Value:
When [WorkflowNode].NodeTypeEnum = 'Status'
	'Shortname for workflow Status Enum'
When [WorkflowNode].NodeTypeEnum = 'Action'
	'Shortname for SystemAction'

[WorkflowNode].TimeToSkip ==> Workflow Step Action Type
When [WorkflowNode].Type = 1 (Action)
0: Manual  : Node will display in ActionManu? 
1: Automatic : 
2: System
When [WorkflowNode].Type = 2 (Status)
Only value is '0'

[WorkflowNode].FromNodeId/ToNodeId only apply to NodeTypeEnum=='Action'

[WorkflowAction] Defines additional actions associated with WorkflowNode
Type:
1. Send Email
2. ActionCode
3. Redirect 
