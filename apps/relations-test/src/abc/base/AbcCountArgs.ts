/*
------------------------------------------------------------------------------ 
This code was generated by Amplication. 
 
Changes to this file will be lost if the code is regenerated. 

There are other ways to to customize your code, see this doc to learn more
https://docs.amplication.com/how-to/custom-code

------------------------------------------------------------------------------
  */
import { ArgsType, Field } from "@nestjs/graphql";
import { ApiProperty } from "@nestjs/swagger";
import { AbcWhereInput } from "./AbcWhereInput";
import { Type } from "class-transformer";

@ArgsType()
class AbcCountArgs {
  @ApiProperty({
    required: false,
    type: () => AbcWhereInput,
  })
  @Field(() => AbcWhereInput, { nullable: true })
  @Type(() => AbcWhereInput)
  where?: AbcWhereInput;
}

export { AbcCountArgs as AbcCountArgs };
