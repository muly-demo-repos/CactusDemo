import { Module, forwardRef } from "@nestjs/common";
import { AuthModule } from "../auth/auth.module";
import { MyEntItyModuleBase } from "./base/myEntIty.module.base";
import { MyEntItyService } from "./myEntIty.service";
import { MyEntItyController } from "./myEntIty.controller";
import { MyEntItyResolver } from "./myEntIty.resolver";

@Module({
  imports: [MyEntItyModuleBase, forwardRef(() => AuthModule)],
  controllers: [MyEntItyController],
  providers: [MyEntItyService, MyEntItyResolver],
  exports: [MyEntItyService],
})
export class MyEntItyModule {}
