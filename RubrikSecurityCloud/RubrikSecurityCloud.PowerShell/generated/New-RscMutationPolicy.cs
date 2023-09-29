// New-RscMutationPolicy.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 1
    /// operations in the 'Policy' API domain:
    /// ['Policies'].
    /// </summary>
    /// <description>
    /// New-RscMutationPolicy creates a new
    /// mutation object for operations
    /// in the 'Policy' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 1 operations
    /// in the 'Policy' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -Policies.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op Policies,
    /// which is equivalent to specifying -Policies.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationPolicy -Policies).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationPolicy -Policies).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Policies operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: Policies
    /// 
    /// $query = New-RscMutationPolicy -Policies
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SeedInitialPoliciesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationPolicy",
        DefaultParameterSetName = "Policies")
    ]
    public class New_RscMutationPolicy : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "Policies",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'Policies' operation
in the 'Policy' API domain.
Description of the operation:
DEPRECATED (use seedEnabledPolicies instead) Seed account with initial policies.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/seedinitialpolicies.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Policies { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "Policies":
                        this.ProcessRecord_Policies();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // seedInitialPolicies.
        internal void ProcessRecord_Policies()
        {
            this._logger.name += " -Policies";
            // Create new graphql operation seedInitialPolicies
            InitMutationSeedInitialPolicies();
        }


        // Create new GraphQL Mutation:
        // seedInitialPolicies: SeedInitialPoliciesReply!
        internal void InitMutationSeedInitialPolicies()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSeedInitialPolicies",
                "",
                "SeedInitialPoliciesReply",
                Mutation.SeedInitialPolicies_ObjectFieldSpec,
                Mutation.SeedInitialPoliciesFieldSpec,
                @""
            );
        }


    } // class New_RscMutationPolicy
}