import { Module, forwardRef } from "@nestjs/common";
import { AuthModule } from "../auth/auth.module";
import { AbcModuleBase } from "./base/abc.module.base";
import { AbcService } from "./abc.service";
import { AbcController } from "./abc.controller";
import { AbcResolver } from "./abc.resolver";

@Module({
  imports: [AbcModuleBase, forwardRef(() => AuthModule)],
  controllers: [AbcController],
  providers: [AbcService, AbcResolver],
  exports: [AbcService],
})
export class AbcModule {}
