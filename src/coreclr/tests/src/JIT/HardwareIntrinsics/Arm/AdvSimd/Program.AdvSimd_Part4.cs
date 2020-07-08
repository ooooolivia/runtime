// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace JIT.HardwareIntrinsics.Arm
{
    public static partial class Program
    {
        static Program()
        {
            TestList = new Dictionary<string, Action>() {
                ["Or.Vector128.UInt32"] = Or_Vector128_UInt32,
                ["Or.Vector128.UInt64"] = Or_Vector128_UInt64,
                ["OrNot.Vector64.Byte"] = OrNot_Vector64_Byte,
                ["OrNot.Vector64.Double"] = OrNot_Vector64_Double,
                ["OrNot.Vector64.Int16"] = OrNot_Vector64_Int16,
                ["OrNot.Vector64.Int32"] = OrNot_Vector64_Int32,
                ["OrNot.Vector64.Int64"] = OrNot_Vector64_Int64,
                ["OrNot.Vector64.SByte"] = OrNot_Vector64_SByte,
                ["OrNot.Vector64.Single"] = OrNot_Vector64_Single,
                ["OrNot.Vector64.UInt16"] = OrNot_Vector64_UInt16,
                ["OrNot.Vector64.UInt32"] = OrNot_Vector64_UInt32,
                ["OrNot.Vector64.UInt64"] = OrNot_Vector64_UInt64,
                ["OrNot.Vector128.Byte"] = OrNot_Vector128_Byte,
                ["OrNot.Vector128.Double"] = OrNot_Vector128_Double,
                ["OrNot.Vector128.Int16"] = OrNot_Vector128_Int16,
                ["OrNot.Vector128.Int32"] = OrNot_Vector128_Int32,
                ["OrNot.Vector128.Int64"] = OrNot_Vector128_Int64,
                ["OrNot.Vector128.SByte"] = OrNot_Vector128_SByte,
                ["OrNot.Vector128.Single"] = OrNot_Vector128_Single,
                ["OrNot.Vector128.UInt16"] = OrNot_Vector128_UInt16,
                ["OrNot.Vector128.UInt32"] = OrNot_Vector128_UInt32,
                ["OrNot.Vector128.UInt64"] = OrNot_Vector128_UInt64,
                ["PolynomialMultiply.Vector64.Byte"] = PolynomialMultiply_Vector64_Byte,
                ["PolynomialMultiply.Vector64.SByte"] = PolynomialMultiply_Vector64_SByte,
                ["PolynomialMultiply.Vector128.Byte"] = PolynomialMultiply_Vector128_Byte,
                ["PolynomialMultiply.Vector128.SByte"] = PolynomialMultiply_Vector128_SByte,
                ["PolynomialMultiplyWideningLower.Vector64.Byte"] = PolynomialMultiplyWideningLower_Vector64_Byte,
                ["PolynomialMultiplyWideningLower.Vector64.SByte"] = PolynomialMultiplyWideningLower_Vector64_SByte,
                ["PolynomialMultiplyWideningUpper.Vector128.Byte"] = PolynomialMultiplyWideningUpper_Vector128_Byte,
                ["PolynomialMultiplyWideningUpper.Vector128.SByte"] = PolynomialMultiplyWideningUpper_Vector128_SByte,
                ["PopCount.Vector64.Byte"] = PopCount_Vector64_Byte,
                ["PopCount.Vector64.SByte"] = PopCount_Vector64_SByte,
                ["PopCount.Vector128.Byte"] = PopCount_Vector128_Byte,
                ["PopCount.Vector128.SByte"] = PopCount_Vector128_SByte,
                ["ReciprocalEstimate.Vector64.Single"] = ReciprocalEstimate_Vector64_Single,
                ["ReciprocalEstimate.Vector64.UInt32"] = ReciprocalEstimate_Vector64_UInt32,
                ["ReciprocalEstimate.Vector128.Single"] = ReciprocalEstimate_Vector128_Single,
                ["ReciprocalEstimate.Vector128.UInt32"] = ReciprocalEstimate_Vector128_UInt32,
                ["ReciprocalSquareRootEstimate.Vector64.Single"] = ReciprocalSquareRootEstimate_Vector64_Single,
                ["ReciprocalSquareRootEstimate.Vector64.UInt32"] = ReciprocalSquareRootEstimate_Vector64_UInt32,
                ["ReciprocalSquareRootEstimate.Vector128.Single"] = ReciprocalSquareRootEstimate_Vector128_Single,
                ["ReciprocalSquareRootEstimate.Vector128.UInt32"] = ReciprocalSquareRootEstimate_Vector128_UInt32,
                ["ReciprocalSquareRootStep.Vector64.Single"] = ReciprocalSquareRootStep_Vector64_Single,
                ["ReciprocalSquareRootStep.Vector128.Single"] = ReciprocalSquareRootStep_Vector128_Single,
                ["ReciprocalStep.Vector64.Single"] = ReciprocalStep_Vector64_Single,
                ["ReciprocalStep.Vector128.Single"] = ReciprocalStep_Vector128_Single,
                ["ReverseElement16.Vector64.Int32"] = ReverseElement16_Vector64_Int32,
                ["ReverseElement16.Vector64.Int64"] = ReverseElement16_Vector64_Int64,
                ["ReverseElement16.Vector64.UInt32"] = ReverseElement16_Vector64_UInt32,
                ["ReverseElement16.Vector64.UInt64"] = ReverseElement16_Vector64_UInt64,
                ["ReverseElement16.Vector128.Int32"] = ReverseElement16_Vector128_Int32,
                ["ReverseElement16.Vector128.Int64"] = ReverseElement16_Vector128_Int64,
                ["ReverseElement16.Vector128.UInt32"] = ReverseElement16_Vector128_UInt32,
                ["ReverseElement16.Vector128.UInt64"] = ReverseElement16_Vector128_UInt64,
                ["ReverseElement32.Vector64.Int64"] = ReverseElement32_Vector64_Int64,
                ["ReverseElement32.Vector64.UInt64"] = ReverseElement32_Vector64_UInt64,
                ["ReverseElement32.Vector128.Int64"] = ReverseElement32_Vector128_Int64,
                ["ReverseElement32.Vector128.UInt64"] = ReverseElement32_Vector128_UInt64,
                ["ReverseElement8.Vector64.Int16"] = ReverseElement8_Vector64_Int16,
                ["ReverseElement8.Vector64.Int32"] = ReverseElement8_Vector64_Int32,
                ["ReverseElement8.Vector64.Int64"] = ReverseElement8_Vector64_Int64,
                ["ReverseElement8.Vector64.UInt16"] = ReverseElement8_Vector64_UInt16,
                ["ReverseElement8.Vector64.UInt32"] = ReverseElement8_Vector64_UInt32,
                ["ReverseElement8.Vector64.UInt64"] = ReverseElement8_Vector64_UInt64,
                ["ReverseElement8.Vector128.Int16"] = ReverseElement8_Vector128_Int16,
                ["ReverseElement8.Vector128.Int32"] = ReverseElement8_Vector128_Int32,
                ["ReverseElement8.Vector128.Int64"] = ReverseElement8_Vector128_Int64,
                ["ReverseElement8.Vector128.UInt16"] = ReverseElement8_Vector128_UInt16,
                ["ReverseElement8.Vector128.UInt32"] = ReverseElement8_Vector128_UInt32,
                ["ReverseElement8.Vector128.UInt64"] = ReverseElement8_Vector128_UInt64,
                ["RoundAwayFromZero.Vector64.Single"] = RoundAwayFromZero_Vector64_Single,
                ["RoundAwayFromZero.Vector128.Single"] = RoundAwayFromZero_Vector128_Single,
                ["RoundAwayFromZeroScalar.Vector64.Double"] = RoundAwayFromZeroScalar_Vector64_Double,
                ["RoundAwayFromZeroScalar.Vector64.Single"] = RoundAwayFromZeroScalar_Vector64_Single,
                ["RoundToNearest.Vector64.Single"] = RoundToNearest_Vector64_Single,
                ["RoundToNearest.Vector128.Single"] = RoundToNearest_Vector128_Single,
                ["RoundToNearestScalar.Vector64.Double"] = RoundToNearestScalar_Vector64_Double,
                ["RoundToNearestScalar.Vector64.Single"] = RoundToNearestScalar_Vector64_Single,
                ["RoundToNegativeInfinity.Vector64.Single"] = RoundToNegativeInfinity_Vector64_Single,
                ["RoundToNegativeInfinity.Vector128.Single"] = RoundToNegativeInfinity_Vector128_Single,
                ["RoundToNegativeInfinityScalar.Vector64.Double"] = RoundToNegativeInfinityScalar_Vector64_Double,
                ["RoundToNegativeInfinityScalar.Vector64.Single"] = RoundToNegativeInfinityScalar_Vector64_Single,
                ["RoundToPositiveInfinity.Vector64.Single"] = RoundToPositiveInfinity_Vector64_Single,
                ["RoundToPositiveInfinity.Vector128.Single"] = RoundToPositiveInfinity_Vector128_Single,
                ["RoundToPositiveInfinityScalar.Vector64.Double"] = RoundToPositiveInfinityScalar_Vector64_Double,
                ["RoundToPositiveInfinityScalar.Vector64.Single"] = RoundToPositiveInfinityScalar_Vector64_Single,
                ["RoundToZero.Vector64.Single"] = RoundToZero_Vector64_Single,
                ["RoundToZero.Vector128.Single"] = RoundToZero_Vector128_Single,
                ["RoundToZeroScalar.Vector64.Double"] = RoundToZeroScalar_Vector64_Double,
                ["RoundToZeroScalar.Vector64.Single"] = RoundToZeroScalar_Vector64_Single,
                ["ShiftArithmetic.Vector64.Int16"] = ShiftArithmetic_Vector64_Int16,
                ["ShiftArithmetic.Vector64.Int32"] = ShiftArithmetic_Vector64_Int32,
                ["ShiftArithmetic.Vector64.SByte"] = ShiftArithmetic_Vector64_SByte,
                ["ShiftArithmetic.Vector128.Int16"] = ShiftArithmetic_Vector128_Int16,
                ["ShiftArithmetic.Vector128.Int32"] = ShiftArithmetic_Vector128_Int32,
                ["ShiftArithmetic.Vector128.Int64"] = ShiftArithmetic_Vector128_Int64,
                ["ShiftArithmetic.Vector128.SByte"] = ShiftArithmetic_Vector128_SByte,
                ["ShiftArithmeticRounded.Vector64.Int16"] = ShiftArithmeticRounded_Vector64_Int16,
                ["ShiftArithmeticRounded.Vector64.Int32"] = ShiftArithmeticRounded_Vector64_Int32,
                ["ShiftArithmeticRounded.Vector64.SByte"] = ShiftArithmeticRounded_Vector64_SByte,
                ["ShiftArithmeticRounded.Vector128.Int16"] = ShiftArithmeticRounded_Vector128_Int16,
                ["ShiftArithmeticRounded.Vector128.Int32"] = ShiftArithmeticRounded_Vector128_Int32,
                ["ShiftArithmeticRounded.Vector128.Int64"] = ShiftArithmeticRounded_Vector128_Int64,
                ["ShiftArithmeticRounded.Vector128.SByte"] = ShiftArithmeticRounded_Vector128_SByte,
                ["ShiftArithmeticRoundedSaturate.Vector64.Int16"] = ShiftArithmeticRoundedSaturate_Vector64_Int16,
                ["ShiftArithmeticRoundedSaturate.Vector64.Int32"] = ShiftArithmeticRoundedSaturate_Vector64_Int32,
                ["ShiftArithmeticRoundedSaturate.Vector64.SByte"] = ShiftArithmeticRoundedSaturate_Vector64_SByte,
                ["ShiftArithmeticRoundedSaturate.Vector128.Int16"] = ShiftArithmeticRoundedSaturate_Vector128_Int16,
                ["ShiftArithmeticRoundedSaturate.Vector128.Int32"] = ShiftArithmeticRoundedSaturate_Vector128_Int32,
                ["ShiftArithmeticRoundedSaturate.Vector128.Int64"] = ShiftArithmeticRoundedSaturate_Vector128_Int64,
                ["ShiftArithmeticRoundedSaturate.Vector128.SByte"] = ShiftArithmeticRoundedSaturate_Vector128_SByte,
                ["ShiftArithmeticRoundedSaturateScalar.Vector64.Int64"] = ShiftArithmeticRoundedSaturateScalar_Vector64_Int64,
                ["ShiftArithmeticRoundedScalar.Vector64.Int64"] = ShiftArithmeticRoundedScalar_Vector64_Int64,
                ["ShiftArithmeticSaturate.Vector64.Int16"] = ShiftArithmeticSaturate_Vector64_Int16,
                ["ShiftArithmeticSaturate.Vector64.Int32"] = ShiftArithmeticSaturate_Vector64_Int32,
                ["ShiftArithmeticSaturate.Vector64.SByte"] = ShiftArithmeticSaturate_Vector64_SByte,
                ["ShiftArithmeticSaturate.Vector128.Int16"] = ShiftArithmeticSaturate_Vector128_Int16,
                ["ShiftArithmeticSaturate.Vector128.Int32"] = ShiftArithmeticSaturate_Vector128_Int32,
                ["ShiftArithmeticSaturate.Vector128.Int64"] = ShiftArithmeticSaturate_Vector128_Int64,
                ["ShiftArithmeticSaturate.Vector128.SByte"] = ShiftArithmeticSaturate_Vector128_SByte,
                ["ShiftArithmeticSaturateScalar.Vector64.Int64"] = ShiftArithmeticSaturateScalar_Vector64_Int64,
                ["ShiftArithmeticScalar.Vector64.Int64"] = ShiftArithmeticScalar_Vector64_Int64,
                ["ShiftLeftAndInsert.Vector64.Byte"] = ShiftLeftAndInsert_Vector64_Byte,
                ["ShiftLeftAndInsert.Vector64.Int16"] = ShiftLeftAndInsert_Vector64_Int16,
                ["ShiftLeftAndInsert.Vector64.Int32"] = ShiftLeftAndInsert_Vector64_Int32,
                ["ShiftLeftAndInsert.Vector64.SByte"] = ShiftLeftAndInsert_Vector64_SByte,
                ["ShiftLeftAndInsert.Vector64.UInt16"] = ShiftLeftAndInsert_Vector64_UInt16,
                ["ShiftLeftAndInsert.Vector64.UInt32"] = ShiftLeftAndInsert_Vector64_UInt32,
                ["ShiftLeftAndInsert.Vector128.Byte"] = ShiftLeftAndInsert_Vector128_Byte,
                ["ShiftLeftAndInsert.Vector128.Int16"] = ShiftLeftAndInsert_Vector128_Int16,
                ["ShiftLeftAndInsert.Vector128.Int32"] = ShiftLeftAndInsert_Vector128_Int32,
                ["ShiftLeftAndInsert.Vector128.Int64"] = ShiftLeftAndInsert_Vector128_Int64,
                ["ShiftLeftAndInsert.Vector128.SByte"] = ShiftLeftAndInsert_Vector128_SByte,
                ["ShiftLeftAndInsert.Vector128.UInt16"] = ShiftLeftAndInsert_Vector128_UInt16,
                ["ShiftLeftAndInsert.Vector128.UInt32"] = ShiftLeftAndInsert_Vector128_UInt32,
                ["ShiftLeftAndInsert.Vector128.UInt64"] = ShiftLeftAndInsert_Vector128_UInt64,
                ["ShiftLeftAndInsertScalar.Vector64.Int64"] = ShiftLeftAndInsertScalar_Vector64_Int64,
                ["ShiftLeftAndInsertScalar.Vector64.UInt64"] = ShiftLeftAndInsertScalar_Vector64_UInt64,
                ["ShiftLeftLogical.Vector64.Byte.1"] = ShiftLeftLogical_Vector64_Byte_1,
                ["ShiftLeftLogical.Vector64.Int16.1"] = ShiftLeftLogical_Vector64_Int16_1,
                ["ShiftLeftLogical.Vector64.Int32.1"] = ShiftLeftLogical_Vector64_Int32_1,
                ["ShiftLeftLogical.Vector64.SByte.1"] = ShiftLeftLogical_Vector64_SByte_1,
                ["ShiftLeftLogical.Vector64.UInt16.1"] = ShiftLeftLogical_Vector64_UInt16_1,
                ["ShiftLeftLogical.Vector64.UInt32.1"] = ShiftLeftLogical_Vector64_UInt32_1,
                ["ShiftLeftLogical.Vector128.Byte.1"] = ShiftLeftLogical_Vector128_Byte_1,
                ["ShiftLeftLogical.Vector128.Int16.1"] = ShiftLeftLogical_Vector128_Int16_1,
                ["ShiftLeftLogical.Vector128.Int64.1"] = ShiftLeftLogical_Vector128_Int64_1,
                ["ShiftLeftLogical.Vector128.SByte.1"] = ShiftLeftLogical_Vector128_SByte_1,
                ["ShiftLeftLogical.Vector128.UInt16.1"] = ShiftLeftLogical_Vector128_UInt16_1,
                ["ShiftLeftLogical.Vector128.UInt32.1"] = ShiftLeftLogical_Vector128_UInt32_1,
                ["ShiftLeftLogical.Vector128.UInt64.1"] = ShiftLeftLogical_Vector128_UInt64_1,
                ["ShiftLeftLogicalSaturate.Vector64.Byte.1"] = ShiftLeftLogicalSaturate_Vector64_Byte_1,
                ["ShiftLeftLogicalSaturate.Vector64.Int16.1"] = ShiftLeftLogicalSaturate_Vector64_Int16_1,
                ["ShiftLeftLogicalSaturate.Vector64.Int32.1"] = ShiftLeftLogicalSaturate_Vector64_Int32_1,
                ["ShiftLeftLogicalSaturate.Vector64.SByte.1"] = ShiftLeftLogicalSaturate_Vector64_SByte_1,
                ["ShiftLeftLogicalSaturate.Vector64.UInt16.1"] = ShiftLeftLogicalSaturate_Vector64_UInt16_1,
                ["ShiftLeftLogicalSaturate.Vector64.UInt32.1"] = ShiftLeftLogicalSaturate_Vector64_UInt32_1,
                ["ShiftLeftLogicalSaturate.Vector128.Byte.1"] = ShiftLeftLogicalSaturate_Vector128_Byte_1,
                ["ShiftLeftLogicalSaturate.Vector128.Int16.1"] = ShiftLeftLogicalSaturate_Vector128_Int16_1,
                ["ShiftLeftLogicalSaturate.Vector128.Int32.1"] = ShiftLeftLogicalSaturate_Vector128_Int32_1,
                ["ShiftLeftLogicalSaturate.Vector128.Int64.1"] = ShiftLeftLogicalSaturate_Vector128_Int64_1,
                ["ShiftLeftLogicalSaturate.Vector128.SByte.1"] = ShiftLeftLogicalSaturate_Vector128_SByte_1,
                ["ShiftLeftLogicalSaturate.Vector128.UInt16.1"] = ShiftLeftLogicalSaturate_Vector128_UInt16_1,
                ["ShiftLeftLogicalSaturate.Vector128.UInt32.1"] = ShiftLeftLogicalSaturate_Vector128_UInt32_1,
                ["ShiftLeftLogicalSaturate.Vector128.UInt64.1"] = ShiftLeftLogicalSaturate_Vector128_UInt64_1,
                ["ShiftLeftLogicalSaturateScalar.Vector64.Int64.1"] = ShiftLeftLogicalSaturateScalar_Vector64_Int64_1,
                ["ShiftLeftLogicalSaturateScalar.Vector64.UInt64.1"] = ShiftLeftLogicalSaturateScalar_Vector64_UInt64_1,
                ["ShiftLeftLogicalSaturateUnsigned.Vector64.Int16.1"] = ShiftLeftLogicalSaturateUnsigned_Vector64_Int16_1,
                ["ShiftLeftLogicalSaturateUnsigned.Vector64.Int32.1"] = ShiftLeftLogicalSaturateUnsigned_Vector64_Int32_1,
                ["ShiftLeftLogicalSaturateUnsigned.Vector64.SByte.1"] = ShiftLeftLogicalSaturateUnsigned_Vector64_SByte_1,
                ["ShiftLeftLogicalSaturateUnsigned.Vector128.Int16.1"] = ShiftLeftLogicalSaturateUnsigned_Vector128_Int16_1,
                ["ShiftLeftLogicalSaturateUnsigned.Vector128.Int32.1"] = ShiftLeftLogicalSaturateUnsigned_Vector128_Int32_1,
                ["ShiftLeftLogicalSaturateUnsigned.Vector128.Int64.1"] = ShiftLeftLogicalSaturateUnsigned_Vector128_Int64_1,
                ["ShiftLeftLogicalSaturateUnsigned.Vector128.SByte.1"] = ShiftLeftLogicalSaturateUnsigned_Vector128_SByte_1,
                ["ShiftLeftLogicalSaturateUnsignedScalar.Vector64.Int64.1"] = ShiftLeftLogicalSaturateUnsignedScalar_Vector64_Int64_1,
                ["ShiftLeftLogicalScalar.Vector64.Int64.1"] = ShiftLeftLogicalScalar_Vector64_Int64_1,
                ["ShiftLeftLogicalScalar.Vector64.UInt64.1"] = ShiftLeftLogicalScalar_Vector64_UInt64_1,
                ["ShiftLeftLogicalWideningLower.Vector64.Byte.1"] = ShiftLeftLogicalWideningLower_Vector64_Byte_1,
                ["ShiftLeftLogicalWideningLower.Vector64.Int16.1"] = ShiftLeftLogicalWideningLower_Vector64_Int16_1,
                ["ShiftLeftLogicalWideningLower.Vector64.Int32.1"] = ShiftLeftLogicalWideningLower_Vector64_Int32_1,
                ["ShiftLeftLogicalWideningLower.Vector64.SByte.1"] = ShiftLeftLogicalWideningLower_Vector64_SByte_1,
                ["ShiftLeftLogicalWideningLower.Vector64.UInt16.1"] = ShiftLeftLogicalWideningLower_Vector64_UInt16_1,
                ["ShiftLeftLogicalWideningLower.Vector64.UInt32.1"] = ShiftLeftLogicalWideningLower_Vector64_UInt32_1,
                ["ShiftLeftLogicalWideningUpper.Vector128.Byte.1"] = ShiftLeftLogicalWideningUpper_Vector128_Byte_1,
                ["ShiftLeftLogicalWideningUpper.Vector128.Int16.1"] = ShiftLeftLogicalWideningUpper_Vector128_Int16_1,
                ["ShiftLeftLogicalWideningUpper.Vector128.Int32.1"] = ShiftLeftLogicalWideningUpper_Vector128_Int32_1,
                ["ShiftLeftLogicalWideningUpper.Vector128.SByte.1"] = ShiftLeftLogicalWideningUpper_Vector128_SByte_1,
                ["ShiftLeftLogicalWideningUpper.Vector128.UInt16.1"] = ShiftLeftLogicalWideningUpper_Vector128_UInt16_1,
                ["ShiftLeftLogicalWideningUpper.Vector128.UInt32.1"] = ShiftLeftLogicalWideningUpper_Vector128_UInt32_1,
                ["ShiftLogical.Vector64.Byte"] = ShiftLogical_Vector64_Byte,
                ["ShiftLogical.Vector64.Int16"] = ShiftLogical_Vector64_Int16,
                ["ShiftLogical.Vector64.Int32"] = ShiftLogical_Vector64_Int32,
                ["ShiftLogical.Vector64.SByte"] = ShiftLogical_Vector64_SByte,
                ["ShiftLogical.Vector64.UInt16"] = ShiftLogical_Vector64_UInt16,
                ["ShiftLogical.Vector64.UInt32"] = ShiftLogical_Vector64_UInt32,
                ["ShiftLogical.Vector128.Byte"] = ShiftLogical_Vector128_Byte,
                ["ShiftLogical.Vector128.Int16"] = ShiftLogical_Vector128_Int16,
                ["ShiftLogical.Vector128.Int32"] = ShiftLogical_Vector128_Int32,
                ["ShiftLogical.Vector128.Int64"] = ShiftLogical_Vector128_Int64,
                ["ShiftLogical.Vector128.SByte"] = ShiftLogical_Vector128_SByte,
                ["ShiftLogical.Vector128.UInt16"] = ShiftLogical_Vector128_UInt16,
                ["ShiftLogical.Vector128.UInt32"] = ShiftLogical_Vector128_UInt32,
                ["ShiftLogical.Vector128.UInt64"] = ShiftLogical_Vector128_UInt64,
                ["ShiftLogicalRounded.Vector64.Byte"] = ShiftLogicalRounded_Vector64_Byte,
                ["ShiftLogicalRounded.Vector64.Int16"] = ShiftLogicalRounded_Vector64_Int16,
                ["ShiftLogicalRounded.Vector64.Int32"] = ShiftLogicalRounded_Vector64_Int32,
                ["ShiftLogicalRounded.Vector64.SByte"] = ShiftLogicalRounded_Vector64_SByte,
                ["ShiftLogicalRounded.Vector64.UInt16"] = ShiftLogicalRounded_Vector64_UInt16,
                ["ShiftLogicalRounded.Vector64.UInt32"] = ShiftLogicalRounded_Vector64_UInt32,
                ["ShiftLogicalRounded.Vector128.Byte"] = ShiftLogicalRounded_Vector128_Byte,
                ["ShiftLogicalRounded.Vector128.Int16"] = ShiftLogicalRounded_Vector128_Int16,
                ["ShiftLogicalRounded.Vector128.Int32"] = ShiftLogicalRounded_Vector128_Int32,
                ["ShiftLogicalRounded.Vector128.Int64"] = ShiftLogicalRounded_Vector128_Int64,
                ["ShiftLogicalRounded.Vector128.SByte"] = ShiftLogicalRounded_Vector128_SByte,
                ["ShiftLogicalRounded.Vector128.UInt16"] = ShiftLogicalRounded_Vector128_UInt16,
                ["ShiftLogicalRounded.Vector128.UInt32"] = ShiftLogicalRounded_Vector128_UInt32,
                ["ShiftLogicalRounded.Vector128.UInt64"] = ShiftLogicalRounded_Vector128_UInt64,
                ["ShiftLogicalRoundedSaturate.Vector64.Byte"] = ShiftLogicalRoundedSaturate_Vector64_Byte,
                ["ShiftLogicalRoundedSaturate.Vector64.Int16"] = ShiftLogicalRoundedSaturate_Vector64_Int16,
                ["ShiftLogicalRoundedSaturate.Vector64.Int32"] = ShiftLogicalRoundedSaturate_Vector64_Int32,
                ["ShiftLogicalRoundedSaturate.Vector64.SByte"] = ShiftLogicalRoundedSaturate_Vector64_SByte,
                ["ShiftLogicalRoundedSaturate.Vector64.UInt16"] = ShiftLogicalRoundedSaturate_Vector64_UInt16,
                ["ShiftLogicalRoundedSaturate.Vector64.UInt32"] = ShiftLogicalRoundedSaturate_Vector64_UInt32,
                ["ShiftLogicalRoundedSaturate.Vector128.Byte"] = ShiftLogicalRoundedSaturate_Vector128_Byte,
                ["ShiftLogicalRoundedSaturate.Vector128.Int16"] = ShiftLogicalRoundedSaturate_Vector128_Int16,
                ["ShiftLogicalRoundedSaturate.Vector128.Int32"] = ShiftLogicalRoundedSaturate_Vector128_Int32,
                ["ShiftLogicalRoundedSaturate.Vector128.Int64"] = ShiftLogicalRoundedSaturate_Vector128_Int64,
                ["ShiftLogicalRoundedSaturate.Vector128.SByte"] = ShiftLogicalRoundedSaturate_Vector128_SByte,
                ["ShiftLogicalRoundedSaturate.Vector128.UInt16"] = ShiftLogicalRoundedSaturate_Vector128_UInt16,
                ["ShiftLogicalRoundedSaturate.Vector128.UInt32"] = ShiftLogicalRoundedSaturate_Vector128_UInt32,
                ["ShiftLogicalRoundedSaturate.Vector128.UInt64"] = ShiftLogicalRoundedSaturate_Vector128_UInt64,
                ["ShiftLogicalRoundedSaturateScalar.Vector64.Int64"] = ShiftLogicalRoundedSaturateScalar_Vector64_Int64,
                ["ShiftLogicalRoundedSaturateScalar.Vector64.UInt64"] = ShiftLogicalRoundedSaturateScalar_Vector64_UInt64,
                ["ShiftLogicalRoundedScalar.Vector64.Int64"] = ShiftLogicalRoundedScalar_Vector64_Int64,
                ["ShiftLogicalRoundedScalar.Vector64.UInt64"] = ShiftLogicalRoundedScalar_Vector64_UInt64,
                ["ShiftLogicalSaturate.Vector64.Byte"] = ShiftLogicalSaturate_Vector64_Byte,
                ["ShiftLogicalSaturate.Vector64.Int16"] = ShiftLogicalSaturate_Vector64_Int16,
                ["ShiftLogicalSaturate.Vector64.Int32"] = ShiftLogicalSaturate_Vector64_Int32,
                ["ShiftLogicalSaturate.Vector64.SByte"] = ShiftLogicalSaturate_Vector64_SByte,
                ["ShiftLogicalSaturate.Vector64.UInt16"] = ShiftLogicalSaturate_Vector64_UInt16,
                ["ShiftLogicalSaturate.Vector64.UInt32"] = ShiftLogicalSaturate_Vector64_UInt32,
                ["ShiftLogicalSaturate.Vector128.Byte"] = ShiftLogicalSaturate_Vector128_Byte,
                ["ShiftLogicalSaturate.Vector128.Int16"] = ShiftLogicalSaturate_Vector128_Int16,
                ["ShiftLogicalSaturate.Vector128.Int32"] = ShiftLogicalSaturate_Vector128_Int32,
                ["ShiftLogicalSaturate.Vector128.Int64"] = ShiftLogicalSaturate_Vector128_Int64,
                ["ShiftLogicalSaturate.Vector128.SByte"] = ShiftLogicalSaturate_Vector128_SByte,
                ["ShiftLogicalSaturate.Vector128.UInt16"] = ShiftLogicalSaturate_Vector128_UInt16,
                ["ShiftLogicalSaturate.Vector128.UInt32"] = ShiftLogicalSaturate_Vector128_UInt32,
                ["ShiftLogicalSaturate.Vector128.UInt64"] = ShiftLogicalSaturate_Vector128_UInt64,
                ["ShiftLogicalSaturateScalar.Vector64.Int64"] = ShiftLogicalSaturateScalar_Vector64_Int64,
                ["ShiftLogicalSaturateScalar.Vector64.UInt64"] = ShiftLogicalSaturateScalar_Vector64_UInt64,
                ["ShiftLogicalScalar.Vector64.Int64"] = ShiftLogicalScalar_Vector64_Int64,
                ["ShiftLogicalScalar.Vector64.UInt64"] = ShiftLogicalScalar_Vector64_UInt64,
                ["ShiftRightAndInsert.Vector64.Byte"] = ShiftRightAndInsert_Vector64_Byte,
                ["ShiftRightAndInsert.Vector64.Int16"] = ShiftRightAndInsert_Vector64_Int16,
                ["ShiftRightAndInsert.Vector64.Int32"] = ShiftRightAndInsert_Vector64_Int32,
            };
        }
    }
}
