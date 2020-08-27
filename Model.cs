
using System.Xml.Serialization;
using System.Collections.Generic;

namespace CSharpMissingFileFinder
{
	[XmlRoot(ElementName="Import", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
	public class Import {
		[XmlAttribute(AttributeName="Project")]
		public string Project { get; set; }
		[XmlAttribute(AttributeName="Condition")]
		public string Condition { get; set; }
	}

	[XmlRoot(ElementName="Configuration", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
	public class Configuration {
		[XmlAttribute(AttributeName="Condition")]
		public string Condition { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName="Platform", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
	public class Platform {
		[XmlAttribute(AttributeName="Condition")]
		public string Condition { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName="PropertyGroup", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
	public class PropertyGroup {
		[XmlElement(ElementName="ProductVersion", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string ProductVersion { get; set; }
		[XmlElement(ElementName="SchemaVersion", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string SchemaVersion { get; set; }
		[XmlElement(ElementName="ProjectGuid", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string ProjectGuid { get; set; }
		[XmlElement(ElementName="ProjectTypeGuids", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string ProjectTypeGuids { get; set; }
		[XmlElement(ElementName="Configuration", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public Configuration Configuration { get; set; }
		[XmlElement(ElementName="Platform", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public Platform Platform { get; set; }
		[XmlElement(ElementName="ApplicationIcon", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string ApplicationIcon { get; set; }
		[XmlElement(ElementName="AssemblyKeyContainerName", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string AssemblyKeyContainerName { get; set; }
		[XmlElement(ElementName="AssemblyName", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string AssemblyName { get; set; }
		[XmlElement(ElementName="AssemblyOriginatorKeyFile", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string AssemblyOriginatorKeyFile { get; set; }
		[XmlElement(ElementName="DefaultClientScript", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string DefaultClientScript { get; set; }
		[XmlElement(ElementName="DefaultHTMLPageLayout", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string DefaultHTMLPageLayout { get; set; }
		[XmlElement(ElementName="DefaultTargetSchema", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string DefaultTargetSchema { get; set; }
		[XmlElement(ElementName="DelaySign", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string DelaySign { get; set; }
		[XmlElement(ElementName="OutputType", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string OutputType { get; set; }
		[XmlElement(ElementName="RootNamespace", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string RootNamespace { get; set; }
		[XmlElement(ElementName="RunPostBuildEvent", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string RunPostBuildEvent { get; set; }
		[XmlElement(ElementName="StartupObject", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string StartupObject { get; set; }
		[XmlElement(ElementName="FileUpgradeFlags", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string FileUpgradeFlags { get; set; }
		[XmlElement(ElementName="UseIISExpress", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string UseIISExpress { get; set; }
		[XmlElement(ElementName="UpgradeBackupLocation", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string UpgradeBackupLocation { get; set; }
		[XmlElement(ElementName="Use64BitIISExpress", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string Use64BitIISExpress { get; set; }
		[XmlElement(ElementName="IISExpressSSLPort", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string IISExpressSSLPort { get; set; }
		[XmlElement(ElementName="IISExpressAnonymousAuthentication", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string IISExpressAnonymousAuthentication { get; set; }
		[XmlElement(ElementName="IISExpressWindowsAuthentication", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string IISExpressWindowsAuthentication { get; set; }
		[XmlElement(ElementName="IISExpressUseClassicPipelineMode", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string IISExpressUseClassicPipelineMode { get; set; }
		[XmlElement(ElementName="UseGlobalApplicationHostFile", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string UseGlobalApplicationHostFile { get; set; }
		[XmlElement(ElementName="TargetFrameworkVersion", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string TargetFrameworkVersion { get; set; }
		[XmlElement(ElementName="TargetFrameworkProfile", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string TargetFrameworkProfile { get; set; }
		[XmlElement(ElementName="NuGetPackageImportStamp", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string NuGetPackageImportStamp { get; set; }
		[XmlElement(ElementName="TypeScriptToolsVersion", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string TypeScriptToolsVersion { get; set; }
		[XmlElement(ElementName="OutputPath", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string OutputPath { get; set; }
		[XmlElement(ElementName="AllowUnsafeBlocks", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string AllowUnsafeBlocks { get; set; }
		[XmlElement(ElementName="BaseAddress", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string BaseAddress { get; set; }
		[XmlElement(ElementName="CheckForOverflowUnderflow", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string CheckForOverflowUnderflow { get; set; }
		[XmlElement(ElementName="ConfigurationOverrideFile", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string ConfigurationOverrideFile { get; set; }
		[XmlElement(ElementName="DefineConstants", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string DefineConstants { get; set; }
		[XmlElement(ElementName="DocumentationFile", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string DocumentationFile { get; set; }
		[XmlElement(ElementName="DebugSymbols", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string DebugSymbols { get; set; }
		[XmlElement(ElementName="FileAlignment", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string FileAlignment { get; set; }
		[XmlElement(ElementName="NoStdLib", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string NoStdLib { get; set; }
		[XmlElement(ElementName="NoWarn", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string NoWarn { get; set; }
		[XmlElement(ElementName="Optimize", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string Optimize { get; set; }
		[XmlElement(ElementName="RegisterForComInterop", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string RegisterForComInterop { get; set; }
		[XmlElement(ElementName="RemoveIntegerChecks", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string RemoveIntegerChecks { get; set; }
		[XmlElement(ElementName="TreatWarningsAsErrors", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string TreatWarningsAsErrors { get; set; }
		[XmlElement(ElementName="WarningLevel", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string WarningLevel { get; set; }
		[XmlElement(ElementName="DebugType", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string DebugType { get; set; }
		[XmlElement(ElementName="ErrorReport", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string ErrorReport { get; set; }
		[XmlElement(ElementName="Prefer32Bit", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string Prefer32Bit { get; set; }
		[XmlElement(ElementName="GenerateSerializationAssemblies", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string GenerateSerializationAssemblies { get; set; }
		[XmlAttribute(AttributeName="Condition")]
		public string Condition { get; set; }
		[XmlElement(ElementName="PreBuildEvent", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string PreBuildEvent { get; set; }
		[XmlElement(ElementName="PostBuildEvent", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string PostBuildEvent { get; set; }
	}

	[XmlRoot(ElementName="Reference", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
	public class Reference {
		[XmlElement(ElementName="HintPath", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string HintPath { get; set; }
		[XmlAttribute(AttributeName="Include")]
		public string Include { get; set; }
		[XmlElement(ElementName="Name", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string Name { get; set; }
		[XmlElement(ElementName="AssemblyFolderKey", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string AssemblyFolderKey { get; set; }
	}

	[XmlRoot(ElementName="ItemGroup", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ItemGroup {
		[XmlElement(ElementName="Reference", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public List<Reference> Reference { get; set; }
		[XmlElement(ElementName="Compile", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public List<Compile> Compile { get; set; }
		[XmlElement(ElementName="Content", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public List<Content> Content { get; set; }
		[XmlElement(ElementName="EmbeddedResource", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public List<EmbeddedResource> EmbeddedResource { get; set; }
		[XmlElement(ElementName="None", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public List<None> None { get; set; }
		[XmlElement(ElementName="Service", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public List<Service> Service { get; set; }
		[XmlElement(ElementName="Folder", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public List<Folder> Folder { get; set; }
	}

	[XmlRoot(ElementName="Compile", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
	public class Compile {
		[XmlElement(ElementName="DependentUpon", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string DependentUpon { get; set; }
		[XmlElement(ElementName="SubType", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string SubType { get; set; }
		[XmlAttribute(AttributeName="Include")]
		public string Include { get; set; }
	}

	[XmlRoot(ElementName="Content", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
	public class Content {
		[XmlAttribute(AttributeName="Include")]
		public string Include { get; set; }
		[XmlElement(ElementName="SubType", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string SubType { get; set; }
		[XmlElement(ElementName="CopyToOutputDirectory", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string CopyToOutputDirectory { get; set; }
	}

	[XmlRoot(ElementName="EmbeddedResource", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
	public class EmbeddedResource {
		[XmlElement(ElementName="DependentUpon", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string DependentUpon { get; set; }
		[XmlAttribute(AttributeName="Include")]
		public string Include { get; set; }
	}

	[XmlRoot(ElementName="None", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
	public class None {
		[XmlAttribute(AttributeName="Include")]
		public string Include { get; set; }
		[XmlElement(ElementName="DependentUpon", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string DependentUpon { get; set; }
	}

	[XmlRoot(ElementName="Service", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
	public class Service {
		[XmlAttribute(AttributeName="Include")]
		public string Include { get; set; }
	}

	[XmlRoot(ElementName="Folder", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
	public class Folder {
		[XmlAttribute(AttributeName="Include")]
		public string Include { get; set; }
	}

	[XmlRoot(ElementName="WebProjectProperties", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
	public class WebProjectProperties {
		[XmlElement(ElementName="UseIIS", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string UseIIS { get; set; }
		[XmlElement(ElementName="AutoAssignPort", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string AutoAssignPort { get; set; }
		[XmlElement(ElementName="DevelopmentServerPort", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string DevelopmentServerPort { get; set; }
		[XmlElement(ElementName="DevelopmentServerVPath", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string DevelopmentServerVPath { get; set; }
		[XmlElement(ElementName="IISUrl", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string IISUrl { get; set; }
		[XmlElement(ElementName="NTLMAuthentication", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string NTLMAuthentication { get; set; }
		[XmlElement(ElementName="UseCustomServer", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string UseCustomServer { get; set; }
		[XmlElement(ElementName="CustomServerUrl", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string CustomServerUrl { get; set; }
		[XmlElement(ElementName="SaveServerSettingsInUserFile", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public string SaveServerSettingsInUserFile { get; set; }
	}

	[XmlRoot(ElementName="FlavorProperties", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
	public class FlavorProperties {
		[XmlElement(ElementName="WebProjectProperties", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public WebProjectProperties WebProjectProperties { get; set; }
		[XmlAttribute(AttributeName="GUID")]
		public string GUID { get; set; }
	}

	[XmlRoot(ElementName="VisualStudio", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
	public class VisualStudio {
		[XmlElement(ElementName="FlavorProperties", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public FlavorProperties FlavorProperties { get; set; }
	}

	[XmlRoot(ElementName="ProjectExtensions", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectExtensions {
		[XmlElement(ElementName="VisualStudio", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public VisualStudio VisualStudio { get; set; }
	}

	[XmlRoot(ElementName="Project", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
	public class Project {
		[XmlElement(ElementName="Import", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public List<Import> Import { get; set; }
		[XmlElement(ElementName="PropertyGroup", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public List<PropertyGroup> PropertyGroup { get; set; }
		[XmlElement(ElementName="ItemGroup", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public List<ItemGroup> ItemGroup { get; set; }
		[XmlElement(ElementName="ProjectExtensions", Namespace="http://schemas.microsoft.com/developer/msbuild/2003")]
		public ProjectExtensions ProjectExtensions { get; set; }
		[XmlAttribute(AttributeName="ToolsVersion")]
		public string ToolsVersion { get; set; }
		[XmlAttribute(AttributeName="xmlns")]
		public string Xmlns { get; set; }
		[XmlAttribute(AttributeName="DefaultTargets")]
		public string DefaultTargets { get; set; }
	}

}
