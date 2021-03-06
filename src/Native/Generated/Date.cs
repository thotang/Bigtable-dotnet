// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/type/date.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Type {

  namespace Proto {

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Date {

      #region Descriptor
      public static pbr::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbr::FileDescriptor descriptor;

      static Date() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            string.Concat(
              "ChZnb29nbGUvdHlwZS9kYXRlLnByb3RvEgtnb29nbGUudHlwZSIwCgREYXRl", 
              "EgwKBHllYXIYASABKAUSDQoFbW9udGgYAiABKAUSCwoDZGF5GAMgASgFQiEK", 
              "D2NvbS5nb29nbGUudHlwZUIJRGF0ZVByb3RvUAGgAQFiBnByb3RvMw=="));
        descriptor = pbr::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
            new pbr::FileDescriptor[] { },
            new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
              new pbr::GeneratedCodeInfo(typeof(global::Google.Type.Date), new[]{ "Year", "Month", "Day" }, null, null, null)
            }));
      }
      #endregion

    }
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Date : pb::IMessage<Date> {
    private static readonly pb::MessageParser<Date> _parser = new pb::MessageParser<Date>(() => new Date());
    public static pb::MessageParser<Date> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Type.Proto.Date.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Date() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Date(Date other) : this() {
      year_ = other.year_;
      month_ = other.month_;
      day_ = other.day_;
    }

    public Date Clone() {
      return new Date(this);
    }

    public const int YearFieldNumber = 1;
    private int year_;
    public int Year {
      get { return year_; }
      set {
        year_ = value;
      }
    }

    public const int MonthFieldNumber = 2;
    private int month_;
    public int Month {
      get { return month_; }
      set {
        month_ = value;
      }
    }

    public const int DayFieldNumber = 3;
    private int day_;
    public int Day {
      get { return day_; }
      set {
        day_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Date);
    }

    public bool Equals(Date other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Year != other.Year) return false;
      if (Month != other.Month) return false;
      if (Day != other.Day) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Year != 0) hash ^= Year.GetHashCode();
      if (Month != 0) hash ^= Month.GetHashCode();
      if (Day != 0) hash ^= Day.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Year != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Year);
      }
      if (Month != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Month);
      }
      if (Day != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Day);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Year != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Year);
      }
      if (Month != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Month);
      }
      if (Day != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Day);
      }
      return size;
    }

    public void MergeFrom(Date other) {
      if (other == null) {
        return;
      }
      if (other.Year != 0) {
        Year = other.Year;
      }
      if (other.Month != 0) {
        Month = other.Month;
      }
      if (other.Day != 0) {
        Day = other.Day;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Year = input.ReadInt32();
            break;
          }
          case 16: {
            Month = input.ReadInt32();
            break;
          }
          case 24: {
            Day = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
