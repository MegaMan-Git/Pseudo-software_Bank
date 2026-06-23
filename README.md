<p>
    این پروژه یک برنامه <strong>Windows Forms</strong> به زبان C# و .NET Framework 4.7.2 است
    که برای یک تمرین/پروژه دانشگاهی طراحی شده و شبیه‌ساز ساده‌ای از یک
    <strong>سیستم بانکی چندنقشی</strong> (مدیر، کارمند، مشتری) را پیاده‌سازی می‌کند.
  </p>

  <h2>ویژگی‌ها</h2>
  <ul>
    <li>سیستم ورود (Login) بر اساس نقش:
      <ul>
        <li><strong>مدیر</strong> (Manager)</li>
        <li><strong>کارمند</strong> (Employee)</li>
        <li><strong>مشتری</strong> (Client)</li>
      </ul>
    </li>
    <li>مدیریت موجودی حساب مشتری:
      <ul>
        <li>افزایش موجودی (Deposit)</li>
        <li>برداشت وجه (Withdraw) با کنترل کافی بودن موجودی</li>
      </ul>
    </li>
    <li>مسدود کردن حساب مشتری (پرچم <code>Cl_ban</code>)</li>
    <li>ثبت تاریخچه ورود کاربران در <code>History</code> مدیر</li>
    <li>صفحه ورود (Login Form) و هدایت به داشبورد بعد از ورود موفق</li>
    <li>جریان ثبت‌نام (Sign Up) از طریق فرم جداگانه</li>
    <li>استفاده از ذخیره‌سازی درون حافظه (in-memory) بدون پایگاه داده</li>
  </ul>

  <h2>ساختار پروژه</h2>

  <h3>فایل‌ها و کلاس‌های اصلی</h3>
  <ul>
    <li><strong><code>BANK.sln</code></strong>:
      فایل سولوشن پروژه در Visual Studio.
    </li>
    <li><strong><code>WindowsFormsApp1/WindowsFormsApp1.csproj</code></strong>:
      فایل پروژه C# Windows Forms.
    </li>
    <li><strong><code>WindowsFormsApp1/Bank.cs</code></strong>:
      هسته منطقی و مدل داده‌ها:
      <ul>
        <li><strong><code>Dataclass</code></strong> (کلاس استاتیک مشترک):
          <ul>
            <li>لیست مشتری‌ها: <code>List&lt;Client&gt; Clients</code></li>
            <li>لیست کارمندان: <code>List&lt;Employee&gt; Employees</code></li>
            <li>مدیر: <code>Manager manager</code></li>
            <li>متغیرهای کمکی مانند <code>NEED</code>، <code>TimeNEED</code>، <code>WithDepNEED</code></li>
          </ul>
        </li>
        <li><strong><code>Client</code></strong>:
          <ul>
            <li>فیلدها:
              <ul>
                <li><code>Cl_ban</code> (وضعیت مسدودی حساب)</li>
                <li><code>Username</code>، <code>Password</code></li>
                <li><code>Money</code> (موجودی اولیه: 10000)</li>
                <li>آرایه‌های <code>Timesave[3]</code> و <code>WithDepMoney[3]</code> برای نگهداری تاریخچه</li>
              </ul>
            </li>
            <li>متدها:
              <ul>
                <li><code>Deposite(int money)</code> – اضافه کردن مبلغ به موجودی</li>
                <li><code>Withraw(int money)</code> – برداشت با بررسی کافی بودن موجودی و نمایش پیام موفقیت</li>
              </ul>
            </li>
          </ul>
        </li>
        <li><strong><code>Employee : Client</code></strong>:
          <ul>
            <li>مشخصات ورود جداگانه:
              <ul>
                <li><code>Em_username</code></li>
                <li><code>Em_password</code></li>
              </ul>
            </li>
            <li>متد <code>ban()</code> که فعلاً همیشه <code>true</code> برمی‌گرداند (به‌نوعی پرچم/پلیس‌دار ساده).</li>
          </ul>
        </li>
        <li><strong><code>Manager : Employee</code></strong>:
          <ul>
            <li>اطلاعات ورود مدیر به‌صورت سخت‌کد شده:
              <ul>
                <li><code>MAIN_User = "Amir rafiey"</code></li>
                <li><code>MAIN_Pass = "12345678"</code></li>
              </ul>
            </li>
            <li>لیست <code>History</code> برای ذخیره تاریخچه رویدادها و ورودها.</li>
            <li>متد <code>remove(string name, string password, double money)</code> (در نسخه فعلی بیشتر جنبه تمرینی دارد و روی آبجکت‌های ذخیره‌شده تغییری اعمال نمی‌کند).</li>
          </ul>
        </li>
      </ul>
    </li>

  <h2>جریان کلی برنامه</h2>
  <ol>
    <li>برنامه از <strong>Form1</strong> (صفحه ورود) شروع می‌شود.</li>
    <li>کاربر نام کاربری و رمز عبور خود را وارد می‌کند.</li>
    <li>بر اساس نقش (مدیر، مشتری، کارمند) احراز هویت می‌شود:
      <ul>
        <li>ابتدا مدیر</li>
        <li>سپس مشتری</li>
        <li>در نهایت کارمند</li>
      </ul>
    </li>
    <li>اگر ورود موفق باشد:
      <ul>
        <li>ورود در <code>History</code> ذخیره می‌شود.</li>
        <li>داشبورد مناسب نقش (مثلاً <code>Form3</code>) باز می‌شود.</li>
      </ul>
    </li>
    <li>اگر کاربر روی لینک ثبت‌نام کلیک کند:
      <ul>
        <li>فرم ثبت‌نام (<code>Form2sign</code>/<code>Form2</code>) باز می‌شود.</li>
      </ul>
    </li>
    <li>در صورت بسته شدن <code>Form1</code>، کل برنامه بسته می‌شود.</li>
  </ol>

  <h2>الگوی طراحی</h2>
  <ul>
    <li>استفاده از یک <strong>کلاس استاتیک</strong> به نام <code>Dataclass</code> برای نگهداری داده‌های سراسری (لیست کاربران، مدیر و ...).</li>
    <li>پیاده‌سازی نقش‌ها با استفاده از <strong>ارث‌بری (Inheritance)</strong>:
      <ul>
        <li><code>Employee : Client</code></li>
        <li><code>Manager : Employee</code></li>
      </ul>
    </li>
    <li>احراز هویت و مدیریت داده‌ها کاملاً <strong>درون‌حافظه‌ای</strong> است و وابستگی به پایگاه داده وجود ندارد.</li>
    <li>رابط کاربری بر پایه فرم‌های ویندوزی (Windows Forms) و رویدادها (Event-driven) طراحی شده است.</li>
  </ul>

  <h2>پیش‌نیازها و اجرای پروژه</h2>
  <ul>
    <li><strong>Visual Studio</strong> (نسخه‌ای که از .NET Framework 4.7.2 پشتیبانی کند)</li>
    <li><strong>.NET Framework 4.7.2</strong></li>
  </ul>

  <h3>روش اجرا</h3>
  <ol>
    <li>سولوشن <code>BANK.sln</code> را در Visual Studio باز کنید.</li>
    <li>پروژه <code>WindowsFormsApp1</code> را به‌عنوان Startup Project تنظیم کنید.</li>
    <li>پروژه را در حالت <strong>Debug</strong> اجرا کنید (کلید F5).</li>
    <li>صفحه ورود (Form1) باز می‌شود و می‌توانید با نقش‌های مختلف تست کنید.</li>
  </ol>

  <h2>یادداشت‌های توسعه‌دهنده</h2>
  <ul>
    <li>این پروژه بیشتر جنبه آموزشی دارد و برای محیط‌های واقعی بانکی مناسب نیست.</li>
    <li>رمز عبور و نام کاربری مدیر به‌صورت سخت‌کد شده در کلاس <code>Manager</code> ذخیره شده است.</li>
    <li>برای توسعه بیشتر:
      <ul>
        <li>می‌توان ذخیره‌سازی را به پایگاه داده (SQL Server یا ...) منتقل کرد.</li>
        <li>متد <code>remove</code> در <code>Manager</code> را می‌توان کامل‌تر پیاده‌سازی کرد تا واقعاً حساب‌ها را حذف/غیرفعال کند.</li>
        <li>منطق مسدودسازی حساب و تاریخچه تراکنش‌ها می‌تواند کامل‌تر و حرفه‌ای‌تر شود.</li>
      </ul>
    </li>
  </ul>
