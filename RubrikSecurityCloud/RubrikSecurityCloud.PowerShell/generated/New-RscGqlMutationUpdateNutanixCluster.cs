// New-RscGqlMutationUpdateNutanixCluster.cs
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

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create new GraphQL Mutation updateNutanixCluster
    /// updateNutanixCluster(input: UpdateNutanixClusterInput!): UpdateNutanixClusterReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateNutanixCluster")
    ]
    public class New_RscGqlMutationUpdateNutanixCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateNutanixCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateNutanixCluster
        /// updateNutanixCluster(input: UpdateNutanixClusterInput!): UpdateNutanixClusterReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateNutanixCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateNutanixCluster()
        {
            this._logger.name += " -updateNutanixCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateNutanixClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateNutanixCluster",
                "($input: UpdateNutanixClusterInput!)",
                "UpdateNutanixClusterReply",
                Mutation.UpdateNutanixCluster_ObjectFieldSpec,
                Mutation.UpdateNutanixClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	patchProperties = @{
		# OPTIONAL
		caCerts = <System.String>
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# OPTIONAL
		hostname = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		username = <System.String>
	}
}"
            );
        }

    } // class New-RscGqlMutationUpdateNutanixCluster
}