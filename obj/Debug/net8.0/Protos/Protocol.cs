// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/protocol.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace DotNetGrpc {

  /// <summary>Holder for reflection information generated from Protos/protocol.proto</summary>
  public static partial class ProtocolReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/protocol.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtocolReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQcm90b3MvcHJvdG9jb2wucHJvdG8SC3Byb3RvY29sX3BiIuABCghMb2dp",
            "blJlcRIRCglwbGF5ZXJfaWQYASABKAkSFAoMYWNjZXNzX3Rva2VuGAIgASgJ",
            "EiUKBHR5cGUYAyABKA4yFy5wcm90b2NvbF9wYi5lTG9naW5UeXBlEg4KBmFw",
            "cF9pZBgEIAEoBRItCgtkZXZpY2VfdHlwZRgFIAEoDjIYLnByb3RvY29sX3Bi",
            "LmVEZXZpY2VUeXBlEhQKDGRldmljZV9tb2RlbBgGIAEoCRIPCgdjb3VudHJ5",
            "GAcgASgJEg4KBm1hcmtldBgIIAEoCRIOCgZyZWdpb24YCSABKAkiKwoITG9n",
            "aW5SZXMSEQoJcGxheWVyX2lkGAEgASgJEgwKBHR5cGUYAiABKAUqUAoKZUxv",
            "Z2luVHlwZRIHCgNERVYQABIJCgVLQUtBTxABEgwKCEZBQ0VCT09LEAISCgoG",
            "R09PR0xFEAMSCQoFQVBQTEUQBBIJCgVHVUVTVBAFKjoKC2VEZXZpY2VUeXBl",
            "EgcKA0lPUxAAEgcKA0FPUxABEgYKAlBDEAISCAoERU1VTBADEgcKA0VUQxAE",
            "Mj4KBUxvZ2luEjUKBUxvZ2luEhUucHJvdG9jb2xfcGIuTG9naW5SZXEaFS5w",
            "cm90b2NvbF9wYi5Mb2dpblJlc0INqgIKRG90TmV0R3JwY2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::DotNetGrpc.eLoginType), typeof(global::DotNetGrpc.eDeviceType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::DotNetGrpc.LoginReq), global::DotNetGrpc.LoginReq.Parser, new[]{ "PlayerId", "AccessToken", "Type", "AppId", "DeviceType", "DeviceModel", "Country", "Market", "Region" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DotNetGrpc.LoginRes), global::DotNetGrpc.LoginRes.Parser, new[]{ "PlayerId", "Type" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// 로그인 플랫폼 종류 enum
  /// </summary>
  public enum eLoginType {
    [pbr::OriginalName("DEV")] Dev = 0,
    [pbr::OriginalName("KAKAO")] Kakao = 1,
    [pbr::OriginalName("FACEBOOK")] Facebook = 2,
    [pbr::OriginalName("GOOGLE")] Google = 3,
    [pbr::OriginalName("APPLE")] Apple = 4,
    [pbr::OriginalName("GUEST")] Guest = 5,
  }

  /// <summary>
  /// 로그인 디바이스 타입 enum
  /// </summary>
  public enum eDeviceType {
    [pbr::OriginalName("IOS")] Ios = 0,
    [pbr::OriginalName("AOS")] Aos = 1,
    [pbr::OriginalName("PC")] Pc = 2,
    [pbr::OriginalName("EMUL")] Emul = 3,
    [pbr::OriginalName("ETC")] Etc = 4,
  }

  #endregion

  #region Messages
  public sealed partial class LoginReq : pb::IMessage<LoginReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LoginReq> _parser = new pb::MessageParser<LoginReq>(() => new LoginReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LoginReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DotNetGrpc.ProtocolReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LoginReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LoginReq(LoginReq other) : this() {
      playerId_ = other.playerId_;
      accessToken_ = other.accessToken_;
      type_ = other.type_;
      appId_ = other.appId_;
      deviceType_ = other.deviceType_;
      deviceModel_ = other.deviceModel_;
      country_ = other.country_;
      market_ = other.market_;
      region_ = other.region_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LoginReq Clone() {
      return new LoginReq(this);
    }

    /// <summary>Field number for the "player_id" field.</summary>
    public const int PlayerIdFieldNumber = 1;
    private string playerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PlayerId {
      get { return playerId_; }
      set {
        playerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "access_token" field.</summary>
    public const int AccessTokenFieldNumber = 2;
    private string accessToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AccessToken {
      get { return accessToken_; }
      set {
        accessToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::DotNetGrpc.eLoginType type_ = global::DotNetGrpc.eLoginType.Dev;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::DotNetGrpc.eLoginType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "app_id" field.</summary>
    public const int AppIdFieldNumber = 4;
    private int appId_;
    /// <summary>
    /// 카카오 app_id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int AppId {
      get { return appId_; }
      set {
        appId_ = value;
      }
    }

    /// <summary>Field number for the "device_type" field.</summary>
    public const int DeviceTypeFieldNumber = 5;
    private global::DotNetGrpc.eDeviceType deviceType_ = global::DotNetGrpc.eDeviceType.Ios;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::DotNetGrpc.eDeviceType DeviceType {
      get { return deviceType_; }
      set {
        deviceType_ = value;
      }
    }

    /// <summary>Field number for the "device_model" field.</summary>
    public const int DeviceModelFieldNumber = 6;
    private string deviceModel_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DeviceModel {
      get { return deviceModel_; }
      set {
        deviceModel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "country" field.</summary>
    public const int CountryFieldNumber = 7;
    private string country_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Country {
      get { return country_; }
      set {
        country_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "market" field.</summary>
    public const int MarketFieldNumber = 8;
    private string market_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Market {
      get { return market_; }
      set {
        market_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "region" field.</summary>
    public const int RegionFieldNumber = 9;
    private string region_ = "";
    /// <summary>
    /// KR, ASIA, US, JP 중 하나
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Region {
      get { return region_; }
      set {
        region_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LoginReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LoginReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerId != other.PlayerId) return false;
      if (AccessToken != other.AccessToken) return false;
      if (Type != other.Type) return false;
      if (AppId != other.AppId) return false;
      if (DeviceType != other.DeviceType) return false;
      if (DeviceModel != other.DeviceModel) return false;
      if (Country != other.Country) return false;
      if (Market != other.Market) return false;
      if (Region != other.Region) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerId.Length != 0) hash ^= PlayerId.GetHashCode();
      if (AccessToken.Length != 0) hash ^= AccessToken.GetHashCode();
      if (Type != global::DotNetGrpc.eLoginType.Dev) hash ^= Type.GetHashCode();
      if (AppId != 0) hash ^= AppId.GetHashCode();
      if (DeviceType != global::DotNetGrpc.eDeviceType.Ios) hash ^= DeviceType.GetHashCode();
      if (DeviceModel.Length != 0) hash ^= DeviceModel.GetHashCode();
      if (Country.Length != 0) hash ^= Country.GetHashCode();
      if (Market.Length != 0) hash ^= Market.GetHashCode();
      if (Region.Length != 0) hash ^= Region.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (PlayerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PlayerId);
      }
      if (AccessToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AccessToken);
      }
      if (Type != global::DotNetGrpc.eLoginType.Dev) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (AppId != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(AppId);
      }
      if (DeviceType != global::DotNetGrpc.eDeviceType.Ios) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DeviceType);
      }
      if (DeviceModel.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(DeviceModel);
      }
      if (Country.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Country);
      }
      if (Market.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Market);
      }
      if (Region.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Region);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (PlayerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PlayerId);
      }
      if (AccessToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AccessToken);
      }
      if (Type != global::DotNetGrpc.eLoginType.Dev) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (AppId != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(AppId);
      }
      if (DeviceType != global::DotNetGrpc.eDeviceType.Ios) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DeviceType);
      }
      if (DeviceModel.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(DeviceModel);
      }
      if (Country.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Country);
      }
      if (Market.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Market);
      }
      if (Region.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Region);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (PlayerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PlayerId);
      }
      if (AccessToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AccessToken);
      }
      if (Type != global::DotNetGrpc.eLoginType.Dev) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (AppId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AppId);
      }
      if (DeviceType != global::DotNetGrpc.eDeviceType.Ios) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DeviceType);
      }
      if (DeviceModel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceModel);
      }
      if (Country.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Country);
      }
      if (Market.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Market);
      }
      if (Region.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Region);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LoginReq other) {
      if (other == null) {
        return;
      }
      if (other.PlayerId.Length != 0) {
        PlayerId = other.PlayerId;
      }
      if (other.AccessToken.Length != 0) {
        AccessToken = other.AccessToken;
      }
      if (other.Type != global::DotNetGrpc.eLoginType.Dev) {
        Type = other.Type;
      }
      if (other.AppId != 0) {
        AppId = other.AppId;
      }
      if (other.DeviceType != global::DotNetGrpc.eDeviceType.Ios) {
        DeviceType = other.DeviceType;
      }
      if (other.DeviceModel.Length != 0) {
        DeviceModel = other.DeviceModel;
      }
      if (other.Country.Length != 0) {
        Country = other.Country;
      }
      if (other.Market.Length != 0) {
        Market = other.Market;
      }
      if (other.Region.Length != 0) {
        Region = other.Region;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            PlayerId = input.ReadString();
            break;
          }
          case 18: {
            AccessToken = input.ReadString();
            break;
          }
          case 24: {
            Type = (global::DotNetGrpc.eLoginType) input.ReadEnum();
            break;
          }
          case 32: {
            AppId = input.ReadInt32();
            break;
          }
          case 40: {
            DeviceType = (global::DotNetGrpc.eDeviceType) input.ReadEnum();
            break;
          }
          case 50: {
            DeviceModel = input.ReadString();
            break;
          }
          case 58: {
            Country = input.ReadString();
            break;
          }
          case 66: {
            Market = input.ReadString();
            break;
          }
          case 74: {
            Region = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            PlayerId = input.ReadString();
            break;
          }
          case 18: {
            AccessToken = input.ReadString();
            break;
          }
          case 24: {
            Type = (global::DotNetGrpc.eLoginType) input.ReadEnum();
            break;
          }
          case 32: {
            AppId = input.ReadInt32();
            break;
          }
          case 40: {
            DeviceType = (global::DotNetGrpc.eDeviceType) input.ReadEnum();
            break;
          }
          case 50: {
            DeviceModel = input.ReadString();
            break;
          }
          case 58: {
            Country = input.ReadString();
            break;
          }
          case 66: {
            Market = input.ReadString();
            break;
          }
          case 74: {
            Region = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class LoginRes : pb::IMessage<LoginRes>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LoginRes> _parser = new pb::MessageParser<LoginRes>(() => new LoginRes());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LoginRes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DotNetGrpc.ProtocolReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LoginRes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LoginRes(LoginRes other) : this() {
      playerId_ = other.playerId_;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LoginRes Clone() {
      return new LoginRes(this);
    }

    /// <summary>Field number for the "player_id" field.</summary>
    public const int PlayerIdFieldNumber = 1;
    private string playerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PlayerId {
      get { return playerId_; }
      set {
        playerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private int type_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LoginRes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LoginRes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerId != other.PlayerId) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerId.Length != 0) hash ^= PlayerId.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (PlayerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PlayerId);
      }
      if (Type != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (PlayerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PlayerId);
      }
      if (Type != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (PlayerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PlayerId);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LoginRes other) {
      if (other == null) {
        return;
      }
      if (other.PlayerId.Length != 0) {
        PlayerId = other.PlayerId;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            PlayerId = input.ReadString();
            break;
          }
          case 16: {
            Type = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            PlayerId = input.ReadString();
            break;
          }
          case 16: {
            Type = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
