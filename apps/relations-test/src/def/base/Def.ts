/*
------------------------------------------------------------------------------ 
This code was generated by Amplication. 
 
Changes to this file will be lost if the code is regenerated. 

There are other ways to to customize your code, see this doc to learn more
https://docs.amplication.com/how-to/custom-code

------------------------------------------------------------------------------
  */
import { ObjectType, Field } from "@nestjs/graphql";
import { ApiProperty } from "@nestjs/swagger";
import { Abc } from "../../abc/base/Abc";
import { ValidateNested, IsOptional, IsDate, IsString } from "class-validator";
import { Type } from "class-transformer";

@ObjectType()
class Def {
  @ApiProperty({
    required: false,
    type: () => Abc,
  })
  @ValidateNested()
  @Type(() => Abc)
  @IsOptional()
  abc?: Abc | null;

  @ApiProperty({
    required: false,
    type: () => [Abc],
  })
  @ValidateNested()
  @Type(() => Abc)
  @IsOptional()
  abcs?: Array<Abc>;

  @ApiProperty({
    required: true,
  })
  @IsDate()
  @Type(() => Date)
  @Field(() => Date)
  createdAt!: Date;

  @ApiProperty({
    required: true,
    type: String,
  })
  @IsString()
  @Field(() => String)
  id!: string;

  @ApiProperty({
    required: true,
  })
  @IsDate()
  @Type(() => Date)
  @Field(() => Date)
  updatedAt!: Date;
}

export { Def as Def };
