#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QB4\",\"Name\":\"QB4Run\"},\"Attributes\":[],\"SourceFile\":\"D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs\",\"Position\":{\"Item1\":5,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QB4\",\"Name\":\"QB4Run\"},\"Attributes\":[],\"SourceFile\":\"D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs\",\"Position\":{\"Item1\":7,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QB4\",\"Name\":\"Set\"},\"Attributes\":[],\"SourceFile\":\"D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs\",\"Position\":{\"Item1\":128,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QB4\",\"Name\":\"Set\"},\"Attributes\":[],\"SourceFile\":\"D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs\",\"Position\":{\"Item1\":130,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.QB4
{
    public partial class QB4Run : Operation<QVoid, (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>, ICallable
    {
        public QB4Run(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "QB4Run";
        String ICallable.FullName => "Quantum.QB4.QB4Run";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumIntrinsicCCNOT
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        public override Func<QVoid, (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)> Body => (__in__) =>
        {
#line 10 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            var num0000 = 0L;
#line 11 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            var num0001 = 0L;
#line 12 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            var num0010 = 0L;
#line 13 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            var num0011 = 0L;
#line 14 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            var num0100 = 0L;
#line 15 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            var num0101 = 0L;
#line 16 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            var num0110 = 0L;
#line 17 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            var num0111 = 0L;
#line 18 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            var num1000 = 0L;
#line 19 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            var num1001 = 0L;
#line 20 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            var num1010 = 0L;
#line 21 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            var num1011 = 0L;
#line 22 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            var num1100 = 0L;
#line 23 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            var num1101 = 0L;
#line 24 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            var num1110 = 0L;
#line 25 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            var num1111 = 0L;
#line hidden
            {
#line 27 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                var qubits = Allocate.Apply(4L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 29 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                    foreach (var test in new Range(1L, 10000L))
#line hidden
                    {
#line 31 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        Set.Apply((Result.Zero, qubits[0L]));
#line 32 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        Set.Apply((Result.Zero, qubits[1L]));
#line 33 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        Set.Apply((Result.Zero, qubits[2L]));
#line 34 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        Set.Apply((Result.Zero, qubits[3L]));
#line 84 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        Set.Apply((Result.One, qubits[0L]));
#line 85 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        Set.Apply((Result.One, qubits[1L]));
#line 86 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        Set.Apply((Result.Zero, qubits[2L]));
#line 87 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        MicrosoftQuantumIntrinsicCCNOT.Apply((qubits[0L], qubits[1L], qubits[2L]));
#line 92 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        var res0 = MicrosoftQuantumIntrinsicM.Apply(qubits[0L]);
#line 93 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        var res1 = MicrosoftQuantumIntrinsicM.Apply(qubits[1L]);
#line 94 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        var res2 = MicrosoftQuantumIntrinsicM.Apply(qubits[2L]);
#line 95 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        var res3 = MicrosoftQuantumIntrinsicM.Apply(qubits[3L]);
#line 97 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        if (((((res3 == Result.Zero) && (res2 == Result.Zero)) && (res1 == Result.Zero)) && (res0 == Result.Zero)))
                        {
#line 97 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                            num0000 = (num0000 + 1L);
                        }

#line 98 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        if (((((res3 == Result.Zero) && (res2 == Result.Zero)) && (res1 == Result.Zero)) && (res0 == Result.One)))
                        {
#line 98 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                            num0001 = (num0001 + 1L);
                        }

#line 99 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        if (((((res3 == Result.Zero) && (res2 == Result.Zero)) && (res1 == Result.One)) && (res0 == Result.Zero)))
                        {
#line 99 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                            num0010 = (num0010 + 1L);
                        }

#line 100 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        if (((((res3 == Result.Zero) && (res2 == Result.Zero)) && (res1 == Result.One)) && (res0 == Result.One)))
                        {
#line 100 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                            num0011 = (num0011 + 1L);
                        }

#line 101 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        if (((((res3 == Result.Zero) && (res2 == Result.One)) && (res1 == Result.Zero)) && (res0 == Result.Zero)))
                        {
#line 101 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                            num0100 = (num0100 + 1L);
                        }

#line 102 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        if (((((res3 == Result.Zero) && (res2 == Result.One)) && (res1 == Result.Zero)) && (res0 == Result.One)))
                        {
#line 102 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                            num0101 = (num0101 + 1L);
                        }

#line 103 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        if (((((res3 == Result.Zero) && (res2 == Result.One)) && (res1 == Result.One)) && (res0 == Result.Zero)))
                        {
#line 103 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                            num0110 = (num0110 + 1L);
                        }

#line 104 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        if (((((res3 == Result.Zero) && (res2 == Result.One)) && (res1 == Result.One)) && (res0 == Result.One)))
                        {
#line 104 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                            num0111 = (num0111 + 1L);
                        }

#line 105 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        if (((((res3 == Result.One) && (res2 == Result.Zero)) && (res1 == Result.Zero)) && (res0 == Result.Zero)))
                        {
#line 105 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                            num1000 = (num1000 + 1L);
                        }

#line 106 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        if (((((res3 == Result.One) && (res2 == Result.Zero)) && (res1 == Result.Zero)) && (res0 == Result.One)))
                        {
#line 106 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                            num1001 = (num1001 + 1L);
                        }

#line 107 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        if (((((res3 == Result.One) && (res2 == Result.Zero)) && (res1 == Result.One)) && (res0 == Result.Zero)))
                        {
#line 107 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                            num1010 = (num1010 + 1L);
                        }

#line 108 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        if (((((res3 == Result.One) && (res2 == Result.Zero)) && (res1 == Result.One)) && (res0 == Result.One)))
                        {
#line 108 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                            num1011 = (num1011 + 1L);
                        }

#line 109 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        if (((((res3 == Result.One) && (res2 == Result.One)) && (res1 == Result.Zero)) && (res0 == Result.Zero)))
                        {
#line 109 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                            num1100 = (num1100 + 1L);
                        }

#line 110 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        if (((((res3 == Result.One) && (res2 == Result.One)) && (res1 == Result.Zero)) && (res0 == Result.One)))
                        {
#line 110 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                            num1101 = (num1101 + 1L);
                        }

#line 111 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        if (((((res3 == Result.One) && (res2 == Result.One)) && (res1 == Result.One)) && (res0 == Result.Zero)))
                        {
#line 111 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                            num1110 = (num1110 + 1L);
                        }

#line 112 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                        if (((((res3 == Result.One) && (res2 == Result.One)) && (res1 == Result.One)) && (res0 == Result.One)))
                        {
#line 112 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                            num1111 = (num1111 + 1L);
                        }
                    }

#line 116 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                    Set.Apply((Result.Zero, qubits[0L]));
#line 117 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                    Set.Apply((Result.Zero, qubits[1L]));
#line 118 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                    Set.Apply((Result.Zero, qubits[2L]));
#line 119 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                    Set.Apply((Result.Zero, qubits[3L]));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(qubits);
                }
            }

#line 123 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            return (num0000, num0001, num0010, num0011, num0100, num0101, num0110, num0111, num1000, num1001, num1010, num1011, num1100, num1101, num1110, num1111);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CCNOT));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Set));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut((Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)> Run(IOperationFactory __m__)
        {
            return __m__.Run<QB4Run, QVoid, (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>(QVoid.Instance);
        }
    }

    public partial class Set : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "Quantum.QB4.Set";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> Body => (__in__) =>
        {
            var (desired,q1) = __in__;
#line 133 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            var current = MicrosoftQuantumIntrinsicM.Apply(q1);
#line 134 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
            if ((desired != current))
            {
#line 136 "D:/Repositories/quantumComputing/quantumSandBox/quantumSandBox/QB4.qs"
                MicrosoftQuantumIntrinsicX.Apply(q1);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((Result,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }
}