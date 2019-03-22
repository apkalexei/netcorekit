// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: project.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NetCoreKit.Samples.Contracts.TodoApi.v1.Grpc {

  /// <summary>Holder for reflection information generated from project.proto</summary>
  public static partial class ProjectReflection {

    #region Descriptor
    /// <summary>File descriptor for project.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProjectReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1wcm9qZWN0LnByb3RvEgdUb2RvQXBpGh9nb29nbGUvcHJvdG9idWYvdGlt",
            "ZXN0YW1wLnByb3RvImoKEVByb2plY3RDcmVhdGVkTXNnEgsKA0tleRgBIAEo",
            "CRIKCgJJZBgCIAEoCRIMCgROYW1lGAMgASgJEi4KCk9jY3VycmVkT24YBCAB",
            "KAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wInsKDlRhc2tDcmVhdGVk",
            "TXNnEgsKA0tleRgBIAEoCRIKCgJJZBgCIAEoCRINCgVUaXRsZRgDIAEoCRIR",
            "CglQcm9qZWN0SWQYBCABKAkSLgoKT2NjdXJyZWRPbhgFIAEoCzIaLmdvb2ds",
            "ZS5wcm90b2J1Zi5UaW1lc3RhbXBCL6oCLE5ldENvcmVLaXQuU2FtcGxlcy5D",
            "b250cmFjdHMuVG9kb0FwaS52MS5HcnBjYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NetCoreKit.Samples.Contracts.TodoApi.v1.Grpc.ProjectCreatedMsg), global::NetCoreKit.Samples.Contracts.TodoApi.v1.Grpc.ProjectCreatedMsg.Parser, new[]{ "Key", "Id", "Name", "OccurredOn" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::NetCoreKit.Samples.Contracts.TodoApi.v1.Grpc.TaskCreatedMsg), global::NetCoreKit.Samples.Contracts.TodoApi.v1.Grpc.TaskCreatedMsg.Parser, new[]{ "Key", "Id", "Title", "ProjectId", "OccurredOn" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProjectCreatedMsg : pb::IMessage<ProjectCreatedMsg> {
    private static readonly pb::MessageParser<ProjectCreatedMsg> _parser = new pb::MessageParser<ProjectCreatedMsg>(() => new ProjectCreatedMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProjectCreatedMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NetCoreKit.Samples.Contracts.TodoApi.v1.Grpc.ProjectReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProjectCreatedMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProjectCreatedMsg(ProjectCreatedMsg other) : this() {
      key_ = other.key_;
      id_ = other.id_;
      name_ = other.name_;
      occurredOn_ = other.occurredOn_ != null ? other.occurredOn_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProjectCreatedMsg Clone() {
      return new ProjectCreatedMsg(this);
    }

    /// <summary>Field number for the "Key" field.</summary>
    public const int KeyFieldNumber = 1;
    private string key_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Key {
      get { return key_; }
      set {
        key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 2;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "OccurredOn" field.</summary>
    public const int OccurredOnFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp occurredOn_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp OccurredOn {
      get { return occurredOn_; }
      set {
        occurredOn_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProjectCreatedMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProjectCreatedMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Key != other.Key) return false;
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (!object.Equals(OccurredOn, other.OccurredOn)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Key.Length != 0) hash ^= Key.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (occurredOn_ != null) hash ^= OccurredOn.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Key.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Key);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (occurredOn_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(OccurredOn);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Key.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (occurredOn_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OccurredOn);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProjectCreatedMsg other) {
      if (other == null) {
        return;
      }
      if (other.Key.Length != 0) {
        Key = other.Key;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.occurredOn_ != null) {
        if (occurredOn_ == null) {
          occurredOn_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        OccurredOn.MergeFrom(other.OccurredOn);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Key = input.ReadString();
            break;
          }
          case 18: {
            Id = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            if (occurredOn_ == null) {
              occurredOn_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(occurredOn_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class TaskCreatedMsg : pb::IMessage<TaskCreatedMsg> {
    private static readonly pb::MessageParser<TaskCreatedMsg> _parser = new pb::MessageParser<TaskCreatedMsg>(() => new TaskCreatedMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TaskCreatedMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NetCoreKit.Samples.Contracts.TodoApi.v1.Grpc.ProjectReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaskCreatedMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaskCreatedMsg(TaskCreatedMsg other) : this() {
      key_ = other.key_;
      id_ = other.id_;
      title_ = other.title_;
      projectId_ = other.projectId_;
      occurredOn_ = other.occurredOn_ != null ? other.occurredOn_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaskCreatedMsg Clone() {
      return new TaskCreatedMsg(this);
    }

    /// <summary>Field number for the "Key" field.</summary>
    public const int KeyFieldNumber = 1;
    private string key_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Key {
      get { return key_; }
      set {
        key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 2;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Title" field.</summary>
    public const int TitleFieldNumber = 3;
    private string title_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ProjectId" field.</summary>
    public const int ProjectIdFieldNumber = 4;
    private string projectId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProjectId {
      get { return projectId_; }
      set {
        projectId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "OccurredOn" field.</summary>
    public const int OccurredOnFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp occurredOn_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp OccurredOn {
      get { return occurredOn_; }
      set {
        occurredOn_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TaskCreatedMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TaskCreatedMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Key != other.Key) return false;
      if (Id != other.Id) return false;
      if (Title != other.Title) return false;
      if (ProjectId != other.ProjectId) return false;
      if (!object.Equals(OccurredOn, other.OccurredOn)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Key.Length != 0) hash ^= Key.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (ProjectId.Length != 0) hash ^= ProjectId.GetHashCode();
      if (occurredOn_ != null) hash ^= OccurredOn.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Key.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Key);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Title);
      }
      if (ProjectId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ProjectId);
      }
      if (occurredOn_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(OccurredOn);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Key.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (ProjectId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProjectId);
      }
      if (occurredOn_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OccurredOn);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TaskCreatedMsg other) {
      if (other == null) {
        return;
      }
      if (other.Key.Length != 0) {
        Key = other.Key;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.ProjectId.Length != 0) {
        ProjectId = other.ProjectId;
      }
      if (other.occurredOn_ != null) {
        if (occurredOn_ == null) {
          occurredOn_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        OccurredOn.MergeFrom(other.OccurredOn);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Key = input.ReadString();
            break;
          }
          case 18: {
            Id = input.ReadString();
            break;
          }
          case 26: {
            Title = input.ReadString();
            break;
          }
          case 34: {
            ProjectId = input.ReadString();
            break;
          }
          case 42: {
            if (occurredOn_ == null) {
              occurredOn_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(occurredOn_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
