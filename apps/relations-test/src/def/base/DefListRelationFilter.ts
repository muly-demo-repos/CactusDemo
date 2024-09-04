/*
------------------------------------------------------------------------------ 
This code was generated by Amplication. 
 
Changes to this file will be lost if the code is regenerated. 

There are other ways to to customize your code, see this doc to learn more
https://docs.amplication.com/how-to/custom-code

------------------------------------------------------------------------------
  */
import { InputType, Field } from "@nestjs/graphql";
import { ApiProperty } from "@nestjs/swagger";
import { DefWhereInput } from "./DefWhereInput";
import { ValidateNested, IsOptional } from "class-validator";
import { Type } from "class-transformer";

@InputType()
class DefListRelationFilter {
  @ApiProperty({
    required: false,
    type: () => DefWhereInput,
  })
  @ValidateNested()
  @Type(() => DefWhereInput)
  @IsOptional()
  @Field(() => DefWhereInput, {
    nullable: true,
  })
  every?: DefWhereInput;

  @ApiProperty({
    required: false,
    type: () => DefWhereInput,
  })
  @ValidateNested()
  @Type(() => DefWhereInput)
  @IsOptional()
  @Field(() => DefWhereInput, {
    nullable: true,
  })
  some?: DefWhereInput;

  @ApiProperty({
    required: false,
    type: () => DefWhereInput,
  })
  @ValidateNested()
  @Type(() => DefWhereInput)
  @IsOptional()
  @Field(() => DefWhereInput, {
    nullable: true,
  })
  none?: DefWhereInput;
}
export { DefListRelationFilter as DefListRelationFilter };
