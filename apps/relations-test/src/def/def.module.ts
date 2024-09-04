import { Module, forwardRef } from "@nestjs/common";
import { AuthModule } from "../auth/auth.module";
import { DefModuleBase } from "./base/def.module.base";
import { DefService } from "./def.service";
import { DefController } from "./def.controller";
import { DefResolver } from "./def.resolver";

@Module({
  imports: [DefModuleBase, forwardRef(() => AuthModule)],
  controllers: [DefController],
  providers: [DefService, DefResolver],
  exports: [DefService],
})
export class DefModule {}
