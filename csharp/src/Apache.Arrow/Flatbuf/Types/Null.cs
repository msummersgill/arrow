// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Apache.Arrow.Flatbuf
{

using global::System;
using global::FlatBuffers;

/// These are stored in the flatbuffer in the Type union below
internal struct Null : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Null GetRootAsNull(ByteBuffer _bb) { return GetRootAsNull(_bb, new Null()); }
  public static Null GetRootAsNull(ByteBuffer _bb, Null obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Null __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


  public static void StartNull(FlatBufferBuilder builder) { builder.StartObject(0); }
  public static Offset<Null> EndNull(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Null>(o);
  }
};


}
